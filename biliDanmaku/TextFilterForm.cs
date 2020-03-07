using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                        this.LogBox.Text += nowtime.ToString() + a + Environment.NewLine;
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
                        this.LogBox.Text += a + "|" + b + "|" + Environment.NewLine;
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
                    this.LogBox.Text += nowtime.ToString() + a + Environment.NewLine;
                    //this.LogBox.Text += nowtime.ToString() + a + Environment.NewLine;
                    this.LogBox.Refresh();
                })
                );
                
                //this.LogBox.Refresh();
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
    }
}
