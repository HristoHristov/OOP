namespace OOPLab.Classes
{
    using System;
    using OOPLab.Interfaces;
    class Sale : ISale
    {
        private Item _item;        
        public Sale(Item item, DateTime dateOfSale)
        {
            this.DateOfSale = dateOfSale;
            this.AddItem(item);
        }
        public Sale(Item item)
            :this(item, DateTime.Now)
        {}
        public DateTime DateOfSale
        {
            get;
            set;
        }

        public void AddItem(Item item)
        {
            this._item = item;
        }
        public Item GetIem
        {
            get { return this._item; }
        }
    }
}