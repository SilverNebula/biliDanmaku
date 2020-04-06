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
using System.Windows.Threading;
using System.Timers;

namespace SCcapture
{
    /// <summary>
    /// PicFrom.xaml 的交互逻辑
    /// </summary>
    public partial class PicFrom : UserControl
    {
        Timer timer = new Timer(500);
        Queue<SCstore> que;
        public PicFrom() {
            InitializeComponent();
            ApplySetting();
            SetVisible(false);
            que = new Queue<SCstore>();
            timer.Interval = 500;
            timer.Elapsed += new ElapsedEventHandler(Update);
            timer.Start();
            return;
        }
        private string img;
        private string vce;
        public void ApplySetting() {
            img = Setting.Default.SCpicture;
            vce = Setting.Default.Voice;
            //BitmapSource imgsource = new BitmapImage(new Uri(img, UriKind.Absolute));
            if (System.IO.File.Exists(img)) {
                this.pic.Source = new Uri(img, UriKind.Absolute);
            }
            if (System.IO.File.Exists(vce)) {
                this.sound.Source = new Uri(vce, UriKind.Absolute);
            }
            return;
        }
        private void SetVisible(bool flag) {
            if (flag == true) {
                this.pic.Visibility = Visibility.Visible;
                this.txtblock.Visibility = Visibility.Visible;
                //this.pic.Play();
            }
            else {
                this.pic.Visibility = Visibility.Hidden;
                this.txtblock.Visibility = Visibility.Hidden;
            }
        }
        private void playpic() {
            pic.Position = TimeSpan.FromMilliseconds(1);
            this.pic.Play();
            return;
        }
        private void playsound() {
            this.sound.Position = TimeSpan.Zero;
            this.sound.Play();
        }
        
        SCstore nowSC = null;
        float timeleft = 0;
        public void act(string name,int count,string msg) {
            que.Enqueue(new SCstore(name, count, msg));
            Console.WriteLine("enqueue");
            if (timer.Enabled == false) {
                timer.Start();
            }
            /*
            this.txtblock.Text = "SC:" + "Name:" + name + " Count:"+count.ToString() + "Color:"+color;
            SetVisible(true);
            playsound();
            */
            return;
        }
        private void Update(object sender, EventArgs e) {
            timeleft -= 0.5f;
            //Console.WriteLine("timeleft:{0}", timeleft);
            if (timeleft <= 0) {//时间到，显示下一条SC
                //Console.WriteLine("queue count:{0}", que.Count);
                if (que.Count > 0) {//有库存的SC
                    nowSC = que.Dequeue();
                    timeleft += Setting.Default.Time;
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        SetVisible(true);
                        this.txtblock.Text = String.Format(Setting.Default.MsgFormat, nowSC.name, nowSC.count, nowSC.message);
                        playsound();
                        playpic();
                    })
                    );
                }
                else {//暂停使用
                    timeleft = 0;
                    nowSC = null;
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        SetVisible(false);
                        timer.Stop();
                    })
                    );
                }
            }

            return;
        }

        private void Sound_MediaEnded(object sender, RoutedEventArgs e) {
            //sound.Position = TimeSpan.Zero;
            sound.Stop();
            return;
        }

        private void Pic_MediaEnded(object sender, RoutedEventArgs e) {
            pic.Position = TimeSpan.FromMilliseconds(1);
            return;
        }
    }
}
