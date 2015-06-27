using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    class Circle : BasicShape
    {
        public Circle(string typeShape, double r)
            : base(typeShape, r)
        { }

        public override double CalculateArea()
        {
            double result = Math.PI * Math.Pow(this.SideA, 2);
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = 2 * Math.PI * this.SideA;
            return result;
        }
    }
}
