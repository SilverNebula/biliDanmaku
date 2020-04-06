using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCcapture
{
    class SCstore
    {
        public string name;
        public int count;
        public string message;
        public Color color;
        public SCstore(string n, int c, string msg) {
            name = n;
            count = c;
            message = msg;
            color = Color.Aqua;
            return;
        }
        /*
        public SCstore(string n,int c,string cl) {
            name = n;
            count = c;
            Console.WriteLine(cl);
            unchecked {
                try {
                    color = Color.FromArgb(int.Parse(cl.Substring(1), System.Globalization.NumberStyles.HexNumber));
                }
                catch {
                    color = Color.Aqua;
                }
                //color = Color.FromArgb((int)(0xff000000 + int.Parse(cl, System.Globalization.NumberStyles.HexNumber)));
            }
            return;
        }
        */
    }
}
