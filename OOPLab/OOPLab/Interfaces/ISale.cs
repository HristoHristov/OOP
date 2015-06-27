namespace OOPLab.Interfaces
{
    using System;
    using OOPLab.Classes;
    interface ISale
    {
         DateTime DateOfSale { get; set; }
         void AddItem(Item item);
    }
}