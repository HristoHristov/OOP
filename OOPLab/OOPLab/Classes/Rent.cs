namespace OOPLab.Classes
{
    using System;
    using OOPLab.Interfaces;
    using System.Collections.Generic;
    class Rent : IRent 
    {
        private  Item _items;       
        private decimal _rentFine;
        private DateTime _dateReturn;
        private string _rentState;
        public Rent(Item item, DateTime dateOfRent, DateTime dateOfDeadline)
        {
            this.AddItem(item);
            this.SaleDate = dateOfRent;
            this.DateOfDeadline = dateOfDeadline;                                  
        }
        public Rent(Item item, DateTime dateOfRent)
            : this(item, dateOfRent, dateOfRent.AddDays(30))
        {}
        public Rent(Item item)
            : this(item, DateTime.Now, DateTime.Now.AddDays(30))
        { }
        
        public DateTime DateOfDeadline
        {
            get;
            set;
        }
        public void Return()
        {
            this._dateReturn = DateTime.Now;
            this._rentState = "Return";
        }
        public string RentState
        {
            get
            {
                if (this._rentState == "Return")
                {
                    return "Return";
                }
                else
                {
                    if ((DateTime.Now - DateOfDeadline).TotalDays > 0)
                    {
                        return "Overdue";
                    }
                    else
                    {
                        return "Panding";
                    }
                }
            }
        }

        public DateTime ReturnDate
        {
            get;
            set;
        }       
        
        public decimal RentFine()
        {            
                if ((ReturnDate - DateOfDeadline).TotalDays > 0)
                {
                    double day = (ReturnDate - DateOfDeadline).TotalDays;
                    this._rentFine = ((1 / 100) * this._items.ItemPrice) * (decimal)day;
                }
                else
                {
                    this._rentFine = 0;
                }          
                return this._rentFine;
        }
        public void AddItem(Item item)
        {
            this._items = item;
        }
        public Item ReturnItem()
        {
            return this._items;
        }

        public DateTime SaleDate
        {
            get;
            set;
        }
    }
}