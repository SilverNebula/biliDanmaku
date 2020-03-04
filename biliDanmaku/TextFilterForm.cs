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
        }
        DateTime nowtime;
        //接受弹幕时处理 
        public void OnReceive(object sender, ReceivedDanmakuArgs e)
        {
            nowtime = DateTime.Now;
            string a = e.Danmaku.CommentText;
            string b = e.Danmaku.UserName;
            if (check1.Checked && a[0] == '【' && a[a.Length - 1] == '】')
            {
                    this.LogBox.Text += nowtime.ToString() + a + Environment.NewLine;
                    this.LogBox.Refresh();
                    return;
            }
            if (textFilter.Check(b))
            {
                this.LogBox.Text += nowtime.ToString() + a + Environment.NewLine;
                this.LogBox.Refresh();
            }
            return;
        }
        //添加监控ID
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (addName.Text != "")
            {
                string tar = addName.Text;
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
