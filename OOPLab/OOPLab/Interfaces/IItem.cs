using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.Interfaces
{
    interface IItem
    {
        string ItemID
        {
            get;
            set;
        }
        string ItemTitle
        {
            get;
            set;
        }
        decimal ItemPrice
        {
            get;
            set;
        }
        void Genres(List<string> value);
    }
}