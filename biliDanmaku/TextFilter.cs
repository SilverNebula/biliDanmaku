using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace biliDanmaku
{
    public class TextFilter
    {
        private HashSet<string> hs;
        public void init()
        {
            if (hs==null)
            {
                hs = new HashSet<string>();
            }
            hs.Clear();
            return;
        }
        public void Add(string name)
        {
            hs.Add(name);
            return;
        }
        public void Del(string name)
        {
            hs.Remove(name);
            return;
        }
        public bool Check(string name)
        {
            return hs.Contains(name);
        }
        public bool Checktxt(string txt)
        {
            return false;
        }
    }
}
