using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportProblem
{
    class Point
    {
        private int x { get; set; }
        private int y { get; set; }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public int X()
        {
            return x;
        }
        public int Y()
        {
            return y;
        }
    }
}
