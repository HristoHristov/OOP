namespace OOPLab.Interfaces
{
    using System;
    using OOPLab.Classes;
    interface IRent
    {
        DateTime SaleDate { get; set; }
        void AddItem(Item item);       
        decimal RentFine();
    }
}