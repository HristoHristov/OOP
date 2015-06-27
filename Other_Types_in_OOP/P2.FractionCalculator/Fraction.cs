using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.FractionCalculator
{
    class Fraction
    {
        private long _a;
        private long _b;
        private static long _nominator;
        private static long _denominator;
        private decimal _result;        

        public Fraction(long a, long b)
        {
            this.A = a;
            this.B = b;
        }
        private Fraction(decimal result)
        {
            this._result = result;
            ToString();
        }
        private long A
        {
            get { return this._a; }
            set { this._a = value; }
        }
        private long B
        {
            get { return this._b; }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Denominatro cannot be 0!");
                }
                this._b = value;
            }
        }
        public long Denominator
        {
            get { return Fraction._denominator; }
            set
            {
                Fraction._denominator = value;
            }
        }
        public long Nominator
        {
            get { return Fraction._nominator; }
        }
        public static Fraction operator +(Fraction firstFraction, Fraction secondFraction)
        {
            long nominator = (firstFraction.A * secondFraction.B) + (firstFraction.B * secondFraction.A);
            long denominator = firstFraction.B * secondFraction.B;
            Fraction._nominator = nominator;
            Fraction._denominator = denominator;
            decimal result = (decimal)nominator / denominator;
            return new Fraction(result);
        }
        public override string ToString()
        {
            return String.Format("{0}", this._result);
        }

    }
}
