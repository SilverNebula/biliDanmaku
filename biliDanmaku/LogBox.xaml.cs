using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace biliDanmaku
{
    /// <summary>
    /// LogBox.xaml 的交互逻辑
    /// </summary>
    public partial class LogBox : UserControl
    {
        public LogBox() {
            InitializeComponent();
        }
        public void AddLog(string str) {
            this.logBox.AppendText(str + Environment.NewLine);
            Maintain();
            return;
        }
        private void Maintain() {
            if (this.logBox.Text.Length > 500) {
                this.logBox.Text = this.logBox.Text.Substring(300);
            }
            this.logBox.ScrollToEnd();
            return;
        }
    }
}
