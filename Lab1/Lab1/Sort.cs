using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Sort
    {
        List<string> l;
        public Sort(List<string> l)
        {
            this.l = l;
        }

        public List<string> SortList()
        {
            this.l.Sort();
            return this.l;
        }
    }
}
