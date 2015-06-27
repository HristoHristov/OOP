using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Customer.Classes
{
    static class CheckingData
    {        
        public static void CheckingString(string name, int minLength, int maxLength, string message)
        {
            if (string.IsNullOrEmpty(name) && name.Length < minLength || name.Length > maxLength)
            {
                throw new FormatException(message);
            }
        }
        public static void IsEquals(object customer1, object customer2, ref bool isEquals)
        {
            if (!Object.Equals(customer1, customer2))
            {
                isEquals = false;
            }
            
        }
        
    }
}
