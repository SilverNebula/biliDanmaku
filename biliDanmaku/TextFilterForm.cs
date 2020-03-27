using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BilibiliDM_PluginFramework;

namespace biliDanmaku
{
    public partial class TextFilterForm : UserControl
    {
        public TextFilter textFilter=new TextFilter();
        public TextFilterForm()
        {
            InitializeComponent();
            textFilter.init();
        }
        DateTime nowtime=new DateTime();
        //接受弹幕时处理 
        private void AddLog(string str) {
            this.LogBox.AppendText(str);
            if (!this.LogBox.Focused) {
                this.LogBox.Select(this.LogBox.Text.Length,0);
                this.LogBox.ScrollToCaret();
            }
            return;
        }
        public void OnReceive(object sender, ReceivedDanmakuArgs e)
        {
            nowtime = DateTime.Now;
            string a = e.Danmaku.CommentText;
            string b = e.Danmaku.UserName;
            if (a == null || a == "") return;
            if (check1.Checked && a[0] == '【' && a[a.Length - 1] == '】')
            {
                    
                    this.Invoke(new Action(() =>
                    {
                        this.AddLog(nowtime.ToString() + a + Environment.NewLine);
                        this.LogBox.Refresh();
                    })
                    );
                    return;
            }
            if(checkBox1.Checked)
            {
                bool flag = false;
                for(int i = 0; i < TargetList.Items.Count;i++)
                {
                    if (a.Contains(TargetList.Items[i].Text))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.AddLog(a + "|" + b + "|" + Environment.NewLine);
                        //this.LogBox.Text += nowtime.ToString() + a + Environment.NewLine;
                        this.LogBox.Refresh();
                    })
                    );
                }
            }
            if (textFilter.Check(b))
            {
                this.Invoke(new Action(() =>
                {
                    this.AddLog(nowtime.ToString() + a + Environment.NewLine);
                    this.LogBox.Refresh();
                })
                );
            }
            return;
        }
        //添加监控ID
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (addName.Text != "")
            {
                string tar = addName.Text;
                textFilter.Add(tar);
                TargetList.Items.Add(tar);
            }
            addName.Text = "";
            return;
        }
        //处理按键删除功能
        private void TargetList_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (TargetList.SelectedItems.Count > 0)
                {
                    string tar = TargetList.SelectedItems[0].Text;
                    textFilter.Del(tar);
                    TargetList.SelectedItems[0].Remove();
                }
            }
            return;
        }

        private void btn_save_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt";
            saveFileDialog.OverwritePrompt = false;
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel) {
                string dst = saveFileDialog.FileName;
                FileStream fileStream = new FileStream(dst, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
                fileStream.Position = fileStream.Length;
                StreamWriter streamWriter = new StreamWriter(fileStream);
                try {
                    
                    streamWriter.Write(this.LogBox.Text);
                    streamWriter.Close();
                }
                catch {
                    MessageBox.Show("保存失败");
                    return;
                }
                this.LogBox.Text = "";
                fileStream.Close();
            }
            return;
        }
    }
}
