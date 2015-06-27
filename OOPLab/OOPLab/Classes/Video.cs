namespace OOPLab.Classes
{
    using System;
    using System.Collections.Generic;
    class Video : Item
    {
        private double _length;
        public Video(string videoId, string videoTitle, decimal price, double length, List<string> genres)
            : base(videoId, videoTitle, price, genres)
        {
            this.Length = length;
        }
        public Video(string videoId, string videoTitle, decimal price, double length, string genre)
            : base(videoId, videoTitle, price)
        {
            this.Length = length;
            this.AddGenre = genre;
        }
        public double Length
        {
            get { return this._length; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The movie length cannot be negative!");
                }
                this._length = value;
            }
        }
        private string AddGenre
        {
            set
            {
                this.CheckString(value);
                this._genres.Add(value);
            }
        }
    }
}