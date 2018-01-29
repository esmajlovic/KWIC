using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class CircularShift
    {
        public List<string> circularShift(List<string> l)
        {
            List<string> shiftList = new List<string>();

            if (l.Count < 1) return l;
            else
            {
                for (int i = 1; i < l.Count; i++) shiftList.Add(l[i]);
                shiftList.Add(l[0]);
                return shiftList;
            }
        }
    }
}
