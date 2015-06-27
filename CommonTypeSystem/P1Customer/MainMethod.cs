using P1Customer.Classes;
using P1Customer.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Customer
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Payment customer1FirstPayment = new Payment("Laptop Lenovo", 1234.50m);
            Payment customer1SecondPayment = new Payment("Laptop HP", 2345.55m);
            List<Payment> customer1ListPayment= new List<Payment>() { customer1FirstPayment, customer1SecondPayment };
            Payment customer2FirstPayment = new Payment("Laptop Dell", 1234.50m);
            List<Payment> customer2ListPayment = new List<Payment>() { customer1FirstPayment, customer1SecondPayment };
            
            Payment custome2SecondPayment = new Payment("Laptop Asus", 2345.55m);
            Customer customer1 = new Customer("Ivancho", "Kurtev", "Ivanov", "8767890987", "sdfdfsdf sdf sf as", "+3598 8777 7819", "ivan@iv.com", customer2ListPayment, CustomerType.Regular);

            Customer customer3 = new Customer("Ivelina", "Hristov", "Nikolova", "8767890987", "sdfdfsdf sdf sf as", "+3598 8777 7819", "ivan@iv.com", customer2ListPayment, CustomerType.Regular);
            Customer customer2 = new Customer("Ivancho", "Kurtev", "Ivanov", "8767890987", "sdfdfsdf sdf sf as", "+3598 8777 7819", "ivan@iv.com", customer2ListPayment, CustomerType.Regular);

            Console.WriteLine("customer2 == customer1 - {0}",customer2 == customer1);
            Console.WriteLine("customer2 != customer1 - {0}", customer2 != customer1);
            Console.WriteLine("customer2.Equals(customer1) - {0}\n", customer2.Equals(customer1));

            Console.WriteLine("customer2 == customer3 - {0}", customer2 == customer3);
            Console.WriteLine("customer2 != customer3 - {0}", customer2 != customer3);
            Console.WriteLine("customer2.Equals(customer3) - {0}\n", customer2.Equals(customer3));
            var customer4 = (Customer)customer2.Clone();
            customer4.FirstName = "Petko";

            Console.WriteLine(customer2);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(customer4);
            Console.WriteLine(customer1.CompareTo(customer4));
            
        }
    }
}
