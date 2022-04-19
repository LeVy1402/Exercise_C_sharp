using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class Triangle : Shape
    {
        private _2DPoint _a, _b, _c;
        public _2DPoint a { get { return _a; } set { _a = value; } }
        public _2DPoint b { get { return _b; } set { _b = value; } }
        public _2DPoint c { get { return _c; } set { _c = value; } }

        public Triangle(_2DPoint a, _2DPoint b, _2DPoint c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        override
        public Shape TinhTien(int x)
        {
            return new Triangle(new _2DPoint(a.x + x, a.y + x), new _2DPoint(b.x + x, b.y + x), new _2DPoint(c.x + x, c.y + x));
        }

        override
        public string ToString()
        {
            return String.Format("Tọa độ A: {0} - {1}" +
                "\nTọa độ B: {2} - {3}" +
                "\nTọa độ C: {4} - {5}", a.x, a.y, b.x, b.y, c.x, c.y);
        }
    }
}
