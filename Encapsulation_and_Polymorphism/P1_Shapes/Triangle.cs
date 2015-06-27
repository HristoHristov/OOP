using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    class Triangle : BasicShape
    {
        private double _sideB;
        private double _sideC;
        private double _height;
        public Triangle(string typeShape, double sideA, double sideB, double sideC, double height)
            : base(typeShape, sideA)
        {
            this.SideB = sideB;
            this.SideC = sideC;
            this.Height = height;
        }
        private double SideB
        {
            set
            {
                CheckData(value);
                this._sideB = value;
            }
        }
        private double SideC
        {
            set
            {
                CheckData(value);
                this._sideC = value;
            }
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
            double result = (this.SideA * this._height) / 2;
            return result;

        }

        public override double CalculatePerimeter()
        {
            double result = this.SideA + this._sideB + this._sideC;
            return result;
        }
    }
}
