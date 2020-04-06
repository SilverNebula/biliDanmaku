using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SCcapture
{
    public partial class SettingForm : Form
    {
        private string soundpath="";
        public SettingForm() {
            InitializeComponent();
            getsetting();
            pictureBox1.ImageLocation = tb_Picture.Text;
        }
        //获取设置
        private void getsetting() {
            tb_ID.Text = Setting.Default.RoomID.ToString();
            tb_min.Text = Setting.Default.MinSC.ToString();
            tb_Picture.Text = Setting.Default.SCpicture.ToString();
            tb_time.Text = Setting.Default.Time.ToString();
            tb_sound.Text = Setting.Default.Voice.ToString();
            tb_Message.Text = Setting.Default.MsgFormat;
            soundpath = tb_sound.Text;
            /*
            try {
                this.Invoke(new Action(() =>
                {
                //Addlog(text);
                //textFilterForm1.OnReceive(sender, e);
                    this.Refresh();
                })
                );
            }
            catch {

            }
            */
            return;
        }
        //应用设置
        private void apply_setting() {
            int roomID = int.Parse(tb_ID.Text);
            float timespan = float.Parse(tb_time.Text);
            int minvalue = int.Parse(tb_min.Text);
            string pic = tb_Picture.Text;
            string fmt = tb_Message.Text;
            if (fmt == null) fmt = " ";
            Setting.Default.RoomID = roomID;
            Setting.Default.MinSC = minvalue;
            Setting.Default.Voice = soundpath;
            Setting.Default.SCpicture = pic;
            Setting.Default.Time = timespan;
            Setting.Default.MsgFormat = fmt;
            Setting.Default.Save();
            return;
        }
        private void btn_OK_Click(object sender, EventArgs e) {
            apply_setting();
            this.Close();
            return;
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
            return;
        }

        private void btn_default_Click(object sender, EventArgs e) {
            tb_ID.Text = "14327465";
            tb_min.Text = "1";
            tb_Picture.Text = "";
            tb_time.Text = "5";
            tb_Message.Text = "ID:{0}  Count:{1}  Msg:{2}";
            return;
        }

        private void tb_Picture_TextChanged(object sender, EventArgs e) {
            return;
        }

        private void findPicture(string path) {
            if (System.IO.File.Exists(path)) {
                pictureBox1.ImageLocation = path;
            }
            return;
        }
        private void tb_Picture_Validated(object sender, EventArgs e) {
            findPicture(tb_Picture.Text);
            return;
        }

        private void btn_findpic_Click(object sender, EventArgs e) {
            OpenFileDialog opf = new OpenFileDialog();
            opf.CheckPathExists = true;
            opf.Filter = "(*.png)|*.png|(*.gif)|*.gif";
            if (opf.ShowDialog() != DialogResult.Cancel) {
                string path = opf.FileName;
                tb_Picture.Text = path;
                findPicture(path);
            }
            return;
        }

        private void tb_Picture_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                findPicture(tb_Picture.Text);
            }
            return;
        }
        //限定房间ID只能输入数字
        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar!=8) {
                Console.WriteLine(e.KeyChar);
                e.Handled = true;
            }
            return;
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            tb_time.Text = (trackBar1.Value*1.0/10).ToString();
            return;
        }

        private void btn_play_Click(object sender, EventArgs e) {
            try {
                Play(soundpath);
            }
            catch {

            }
            return;
        }
        private void findsound(string path) {
            if (System.IO.File.Exists(path)) {
                soundpath = path;
            }
            return;
        }
        private void btn_findsound_Click(object sender, EventArgs e) {
            OpenFileDialog opf = new OpenFileDialog();
            opf.CheckPathExists = true;
            opf.Filter = "(*.mp3)|*.mp3|(*.wav)|*.wav";
            if (opf.ShowDialog() != DialogResult.Cancel) {
                string path = opf.FileName;
                tb_sound.Text = path;
                findsound(path);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                findsound(tb_sound.Text);
            }
        }

        private void tb_time_TextChanged(object sender, EventArgs e) {
            float res = 0.0f;
            if (float.TryParse(tb_time.Text,out res)) {
                if (res >= 20) res = 20;
                if (res <= 1) res = 1;
                trackBar1.Value = (int)(res * 10);
            }
            return;
        }

        public static uint SND_ASYNC = 0x0001;
        public static uint SND_FILENAME = 0x00020000;
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand,
        string lpstrReturnString, uint uReturnLength, uint hWndCallback);
        public void Play(string path) {
            mciSendString(@"close temp_alias", null, 0, 0);
            string cmmd= (@"open "" "+ path + " \" alias temp_alias").ToString();
            mciSendString(cmmd, null, 0, 0);
            mciSendString("play temp_alias", null, 0, 0);
            return;
        }
    }
}
