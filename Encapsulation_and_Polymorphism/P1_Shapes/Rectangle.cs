using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    class Rectangle : BasicShape
    {
        private double _height;
        public Rectangle(string typeShape, double width, double height)
            : base(typeShape, width)
        {
            this.Height = height;
        }
        private double Height
        {
            set
            {
                CheckData(value);
                this._height = value;
            }
        }

        public override double CalculateArea()
        {
            double result = this.SideA * this._height;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = (this.SideA + this._height) * 2;
            return result;
        }
    }
}
