namespace OOPLab.Classes
{
    using System;
    using System.Collections.Generic;
    enum AgeRestriction
    {
        Minor, Teen
    }
    class Game : Item
    {
        private AgeRestriction _ageRestriction = AgeRestriction.Minor;
        public Game(string gameId, string gameTitle, decimal price, List<string> genres, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(gameId, gameTitle, price, genres)
        {
            this._ageRestriction = ageRestriction;
        }

        public Game(string gameId, string gameTitle, decimal price, string genre, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(gameId, gameTitle, price)
        {
            this._ageRestriction = ageRestriction;
            this.AddGenre = genre;
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