namespace OOPLab.Classes
{
    using System;
    using OOPLab.Interfaces;
    using System.Collections.Generic;
    class Item : IItem
    {
        private string _itemID;
        private string _itemTitle;
        private decimal _itemPrice;
        protected List<string> _genres = new List<string>();
        public Item(string itemId, string itemTitle, decimal price, List<string> genres)            
        {
            this.ItemID = itemId;
            this.ItemTitle = itemTitle;
            this.Genres(genres);
            this.ItemPrice = price;
        }
        public Item(string itemId, string itemTitle, decimal price)
            :this(itemId, itemTitle, price, null)
        {}
        public string ItemID
        {
            get { return this._itemID; }
            set 
            {
                this.CheckString(value);
                this._itemID = value;
            }
        }
        public string ItemTitle
        {
            get { return this._itemTitle; }
            
            set
            {
                this.CheckString(value);
                this._itemTitle = value;
            }
        }
        public decimal ItemPrice
        {
            get { return this._itemPrice; }            

            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be negative!");
                }
                this._itemPrice = value;
            }
        }

        public void Genres(List<string> genres)
        {
            if (genres != null)
            {
                foreach (var genre in genres)
                {
                    this.CheckString(genre);
                    this._genres.Add(genre);
                }
            }            
        }
        protected void CheckString(string value)
        {
            if((value == "") || (value.Length < 3 || value.Length > 40))
            {
                throw new FormatException("The value should be more than 3 and less than 40 characters!" + value);
            }
        }
    }
}