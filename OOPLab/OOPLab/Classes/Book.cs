namespace OOPLab.Classes
{
    using System;
    using System.Collections.Generic;    
    class Book : Item
    {
        private string _author;
        public Book(string bookId, string bookTitle, decimal price, string author, List<string> genres)
            : base(bookId, bookTitle, price, genres)
        {
            this.Author = author;
        }
        public Book(string bookId, string bookTitle, decimal price, string author, string genre)
            : base(bookId, bookTitle, price)
        {
            this.Author = author;
            this.AddGenre = genre;
        }
        public string Author
        {
            get { return this._author; }
            set
            {
                this.CheckString(value);
                this._author = value;
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
