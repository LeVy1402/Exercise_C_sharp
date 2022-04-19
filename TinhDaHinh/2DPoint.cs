using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class _2DPoint
    {
        private int _x, _y;
        public int x { get { return _x; } set { _x = value; } }
        public int y { get { return _y; } set { _y = value; } }

        public _2DPoint(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
