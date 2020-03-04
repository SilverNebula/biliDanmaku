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
            return;
        }
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
            MainLog.AppendText(str + Environment.NewLine);
            MainLog.Refresh();
            return;
        }

        private async void LinkStartAsync(object sender, EventArgs e)
        {
            int roomid = int.Parse(RoomID.Text);
            try
            {
                var result = await DMloader.ConnectAsync(roomid);
            }
            catch (Exception)
            {
                MessageBox.Show("连接错误", "ERROR", MessageBoxButtons.OK);
                return;
            }
            Addlog("正在连接");
            return;
        }
        private void OnReceivedDanmaku(object sender,ReceivedDanmakuArgs e)
        {
            string text = e.Danmaku.CommentText;
            if (text == null) return;
            //Console.WriteLine(text);
            this.Invoke(new Action(() => 
                {
                Addlog(text);
                })
            );
            return;
        }
        private void OnReceivedRoomCount(object sender,ReceivedRoomCountArgs e)
        {
            return;
        }
        private void OnDisconnected(object sender, DisconnectEvtArgs e)
        {
            Addlog("连接断开");
            //尝试重连 
            return;
        }
        private void OnLogMassage(object sender, LogMessageArgs e)
        {
            Addlog(e.message);
            return;
        }
    }
}
