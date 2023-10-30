using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Route
    {
        public int Start { get; }
        public int End { get; }

        public Route(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
