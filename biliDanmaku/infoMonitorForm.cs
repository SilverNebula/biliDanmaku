using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biliDanmaku
{
    public partial class infoMonitorForm : UserControl
    {
        public infoMonitorForm() {
            InitializeComponent();
            timer1.Stop();
        }
        public void UpdateUI() {
            if (InfoMonitor.succeed == false) {
                this.fan_number.Text = "ERROR";
                this.play_number.Text = "ERROR";
                return;
            }
            this.fan_number.Text = InfoMonitor.fan_number.ToString();
            this.play_number.Text = InfoMonitor.play_number.ToString();
            return;
        }
        double lasttime = 0;
        double UPDinterval = 30000;//更新间隔
        private void UPD(object sender, EventArgs e) {
            lasttime += timer1.Interval;
            if (lasttime >= UPDinterval) {
                lasttime = 0;
                UpdateUI();
            }
            refresh_time.Text = (Math.Round(30000 - lasttime)/1000).ToString();
            return;
        }

        private async void btn_start_Click(object sender, EventArgs e) {
            int uid = int.Parse(uidbox.Text);
            Console.WriteLine("uid:{0}", uid);
            lasttime = 0;
            bool result = await InfoMonitor.Getinfo(uid);
            timer1.Start();
            UpdateUI();
            return;
        }
    }
}
