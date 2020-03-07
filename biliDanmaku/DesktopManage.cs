using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace biliDanmaku
{
    class DesktopManage
    {

        [DllImport("user32.dll", EntryPoint = "SetParent")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        public static void Apply(MainForm FM) {
            SetParent(FM.Handle.ToInt32(), FindWindow("Progman", "Program Manager"));
            Rectangle ScreenArea = System.Windows.Forms.Screen.GetWorkingArea(FM);
            return;
        }
    }
}
