using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1GalacticGPS
{
    struct Location
    {
        private double _latitude;
        private Planet _planet;
        private double _longitude;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this._planet = planet;
        }
        public double Longitude
        {
            get { return this._longitude; }
            set
            {
                this.CheckingNum(value);
                this._longitude = value;
            }
        }
        public double Latitude
        {
            get { return this._latitude; }
            set
            {
                this.CheckingNum(value);
                this._latitude = value;
            }
        }
        private void CheckingNum(double num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Number cannot be negative");
            }
        }
        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", Latitude, Longitude, _planet);
        }
    }
}
