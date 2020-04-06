using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCcapture
{
    public partial class PictureForm : Form
    {
        public PictureForm() {
            InitializeComponent();
        }
        public void act(string name, int count, string msg) {
            this.Invoke(new Action(() =>
            {
                this.picFrom1.act(name, count, msg);
            })
            );
            
            /*
            this.txtblock.Text = "SC:" + "Name:" + name + " Count:" + count.ToString() + "Color:" + color;
            SetVisible(true);
            timer.Interval = Setting.Default.Time * 1000;
            timer.Start();
            */
            return;
        }
        public void Apply() {
            try {
                this.Invoke(new Action(() =>
                {
                    picFrom1.ApplySetting();
                })
                );
            }
            catch {

            }
            return;
        }
    }
}
