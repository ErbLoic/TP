using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMeteo
{
    interface IExempleInterface
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double distance { get; }

        public double somme { get; }
    }
    class ExempleClass: IExempleInterface
    {

        public int X { get; set; }
        public int Y { get; set; }

        public double somme => X + Y;

        public double distance =>Math.Sqrt(X*X+Y*Y);
        public ExempleClass(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
