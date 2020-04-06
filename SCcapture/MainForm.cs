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

namespace SCcapture
{
    public partial class MainForm : Form
    {
        private readonly DanmakuLoader DMloader;
        private bool PicboxOpened = false;
        public MainForm() {
            DMloader = new DanmakuLoader();
            InitializeComponent();
            initDeligate();
        }
        private void initDeligate() {

            DMloader.ReceivedDanmaku += OnReceivedDanmaku;
            DMloader.ReceivedRoomCount += OnReceivedRoomCount;
            DMloader.Disconnected += OnDisconnected;
            DMloader.LogMessage += OnLogMassage;
            return;
        }
        public void Addlog(string str) {
            this.Invoke(new Action(() =>
            {
                this.logBox1.AddLog(str);
                //textFilterForm1.OnReceive(sender, e);
            })
            );
            //((LogBox)this.elementHost1.Child).AddLog(str);
            //MainLog.AppendText(str + Environment.NewLine);
            //MainLog.Refresh();
            return;
        }

        private async void LinkStartAsync(object sender, EventArgs e) {
            int roomid = Setting.Default.RoomID;
            try {
                var result = await DMloader.ConnectAsync(roomid);
            }
            catch (Exception) {
                MessageBox.Show("连接错误", "ERROR", MessageBoxButtons.OK);
                return;
            }
            //Properties.Settings.Default.roomid = roomid;
            Addlog("正在连接");
            return;
        }
        private void OnReceivedDanmaku(object sender, ReceivedDanmakuArgs e) {
            DanmakuModel dm = e.Danmaku;
            Console.WriteLine(dm.MsgType);
            switch (e.Danmaku.MsgType) {
                case MsgTypeEnum.GiftSend: 
                    {
                        Addlog("收到礼物" + "ID:" + dm.UserID + " Name:" + dm.UserName + 
                            "礼物名:"+dm.GiftName + "礼物数" + dm.GiftCount);
                        break;
                    }
                case MsgTypeEnum.GuardBuy: 
                    {
                        Addlog("收到舰长" + "ID:" + dm.UserID + " Name:"+dm.UserName);
                        break;
                    }
                case MsgTypeEnum.SUPER_CHAT_MESSAGE: 
                    {
                        Addlog("收到SC" + "ID:" + dm.UserID + " Name:" + dm.UserName
                            + " 金额:" + dm.GiftCount +" 内容:" +dm.CommentText 
                            +" 颜色:"+dm.GiftName);
                        if(dm.GiftCount > Setting.Default.MinSC) {
                            picform.act(dm.UserName, dm.GiftCount, dm.CommentText);
                        }
                        break;
                    }
                case MsgTypeEnum.Comment: //接收弹幕
                    {
                        break;
                        string text = e.Danmaku.CommentText;
                        if (text == null) return;
                        //Console.WriteLine(text);
                        this.Invoke(new Action(() =>
                        {
                            Addlog(text);
                            //textFilterForm1.OnReceive(sender, e);
                        })
                        );
                        break;
                    }
                case MsgTypeEnum.LiveStart: //接收开播信息
                    {
                        //textFilterForm1.reset_flag(true);
                        break;
                    }
                case MsgTypeEnum.LiveEnd: {
                        //textFilterForm1.reset_flag(false);
                        break;
                    }
            }
            return;
        }
        private void OnReceivedRoomCount(object sender, ReceivedRoomCountArgs e) {
            return;
        }
        private void OnDisconnected(object sender, DisconnectEvtArgs e) {
            //Addlog("连接断开");
            //尝试重连 
            return;
        }
        private void OnLogMassage(object sender, LogMessageArgs e) {

            //Addlog(e.message);
            return;
        }
        private void btn_Start_Click(object sender, EventArgs e) {
            this.LinkStartAsync(sender,e);
            return;
        }

        private void btn_Setting_Click(object sender, EventArgs e) {
            SettingForm stf = new SettingForm();
            stf.ShowDialog();
            return;
        }

        //private void btn_Exit_Click(object sender, EventArgs e) {

        //}
        PictureForm picform = new PictureForm();
        private void btn_Open_Click(object sender, EventArgs e) {
            if (this.PicboxOpened == false) {
                this.PicboxOpened = true;
                btn_Open.Text = "Close";
                picform.Apply();
                picform.Show();
            }
            else {
                this.PicboxOpened = false;
                btn_Open.Text = "OpenPicture";
                picform.Hide();
            }
            return;
        }

        private void btn_test_Click(object sender, EventArgs e) {
            try {
                picform.act("测试用户名", 30, "测试消息");
            }
            catch {

            }
            return;
        }
    }
}
