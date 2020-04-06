using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiliDMLib;
using BilibiliDM_PluginFramework;
using System.Runtime.InteropServices;

namespace biliDanmaku
{
    public partial class MainForm : Form
    {
        private readonly DanmakuLoader DMloader;
        public MainForm()
        {
            InitializeComponent();
            DMloader = new DanmakuLoader();
            basicLink.Text = "https://live.bilibili.com//";
            initDeligate();
            initUI();
            this.Opacity = 1;//调整透明度
            return;
        }
        //读取用户变量，初始化UI
        public void initUI() {
            this.RoomID.Text = Properties.Settings.Default.roomid.ToString();
            //
            return;
        }
        //初始化委托
        private void initDeligate()
        {
            
            DMloader.ReceivedDanmaku += OnReceivedDanmaku;
            DMloader.ReceivedRoomCount += OnReceivedRoomCount;
            DMloader.Disconnected += OnDisconnected;
            DMloader.LogMessage += OnLogMassage;
            
            return;
        }
        public void Addlog(string str)
        {
            this.logBox1.AddLog(str);
            //((LogBox)this.elementHost1.Child).AddLog(str);
            //MainLog.AppendText(str + Environment.NewLine);
            //MainLog.Refresh();
            return;
        }

        private async void LinkStartAsync(object sender, EventArgs e)
        {
            int roomid = int.Parse(RoomID.Text);
            //Properties.Settings.Default.roomid = roomid;
            Properties.Settings.Default.Save();
            try
            {
                var result = await DMloader.ConnectAsync(roomid);
            }
            catch (Exception)
            {
                MessageBox.Show("连接错误", "ERROR", MessageBoxButtons.OK);
                return;
            }
            //Properties.Settings.Default.roomid = roomid;
            Addlog("正在连接");
            return;
        }
        private void OnReceivedDanmaku(object sender,ReceivedDanmakuArgs e)
        {
            switch (e.Danmaku.MsgType)
            {
                case MsgTypeEnum.Comment: //接收弹幕
                    {
                        string text = e.Danmaku.CommentText;
                        if (text == null) return;
                        Console.WriteLine("in1");
                        Console.WriteLine(text);
                        this.Invoke(new Action(() =>
                        {
                            Addlog(text);
                            textFilterForm1.OnReceive(sender, e);
                        })
                        );
                        break;
                    }
                case MsgTypeEnum.LiveStart: //接收开播信息
                    {
                        textFilterForm1.reset_flag(true);
                        break;
                    }
                case MsgTypeEnum.LiveEnd: 
                    {
                        textFilterForm1.reset_flag(false);
                        break;
                    }
            }
            return;
        }
        private void OnReceivedRoomCount(object sender,ReceivedRoomCountArgs e)
        {
            return;
        }
        private void OnDisconnected(object sender, DisconnectEvtArgs e)
        {
            //Addlog("连接断开");
            //尝试重连 
            return;
        }
        private void OnLogMassage(object sender, LogMessageArgs e)
        {
            
            //Addlog(e.message);
            return;
        }

        private void textFilterForm1_Load(object sender, EventArgs e) {

        }

        private void btn_fold_Click(object sender, EventArgs e) {
            if (elementHost1.Visible == true) {
                elementHost1.Visible = false;
                basicLink.Visible = false;
                RoomID.Visible = false;
                button1.Visible = false;
                this.textFilterForm1.Location = new Point(10, 182);
                this.infoMonitorForm1.Location = new Point(40, 13);
                this.btn_fold.Location = new Point(10, 36);
                this.button_help.Location = new Point(10, 76);
                this.textFilterForm1.Anchor = AnchorStyles.Left | AnchorStyles.Top 
                    | AnchorStyles.Bottom;
                this.Width = 600;
                this.Height = 669;
            }
            else {
                elementHost1.Visible = true;
                basicLink.Visible = true;
                RoomID.Visible = true;
                button1.Visible = true;
                this.Width = 970;
                this.Height = 600;
                this.textFilterForm1.Location = new Point(399, 182);
                this.infoMonitorForm1.Location= new Point(569, 13);
                this.btn_fold.Location= new Point(510, 29);
                this.button_help.Location = new Point(510, 76);
                this.textFilterForm1.Anchor = (AnchorStyles)15;
            }
            return;
        }

        private void button_help_Click(object sender, EventArgs e) {
            HelpForm hpf = new HelpForm();
            hpf.Show();
            return;
        }
    }
}
