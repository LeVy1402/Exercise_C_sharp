using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class Rectangle : Shape
    {
        private _2DPoint _a, _b, _c, _d;
        public _2DPoint a { get { return _a; } set { _a = value; } }
        public _2DPoint b { get { return _b; } set { _b = value; } }
        public _2DPoint c { get { return _c; } set { _c = value; } }
        public _2DPoint d { get { return _d; } set { _d = value; } }

        public Rectangle(_2DPoint a, _2DPoint b, _2DPoint c, _2DPoint d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        override
        public Shape TinhTien(int x)
        {
            return new Rectangle(new _2DPoint(a.x + x, a.y + x), new _2DPoint(b.x + x, b.y + x), new _2DPoint(c.x + x, c.y + x), new _2DPoint(d.x + x, d.y + x));
        }

        override
        public string ToString()
        {
            return String.Format("" +
                "Tọa độ A: {0} - {1}" +
                "\nTọa độ B: {2} - {3}" +
                "\nTọa độ C: {4} - {5}" +
                "\nTọa độ D: {6} - {7}", a.x, a.y, b.x, b.y, c.x, c.y, d.x, d.y);
        }
    }
}
