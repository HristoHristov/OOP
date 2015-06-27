using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Shapes
{
    abstract class BasicShape : IShape
    {
        private string _shapeName;
        private double _sideA;
        public BasicShape(string shapeType, double sideA)
        {
            this.ShapeName = shapeType;
            this.SideA = sideA;
        }
        public string ShapeName
        {
            get { return this._shapeName; }
            set
            {
                if (value != "Triangle" && value != "Rectangle" && value != "Circle")
                {
                    throw new FormatException("The shape should be Rectangle, Triangle or Circle!");
                }
                this._shapeName = value;
            }
        }
        public double SideA
        {
            get
            {
                return this._sideA;
            }
            private set
            {
                CheckData(value);
                this._sideA = value;
            }
        }
        protected void CheckData(double num)
        {
            if (num < 0)
            {
                throw new FormatException("The number can not be less than 0!");
            }
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
