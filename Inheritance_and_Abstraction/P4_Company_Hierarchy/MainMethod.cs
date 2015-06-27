using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_Company_Hierarchy.Classes;
namespace P4_Company_Hierarchy
{
    class MainMethod
    {
        static void Main()
        {
            Manager svetlio = new Manager(11234, "Svetlin", "Nakov", 5000);
           

            SalesEmployee pesho = new SalesEmployee(11071, "Petyr", "Peshev", 1500.99, "Sales");
            SalesEmployee radi = new SalesEmployee(11071, "Radincho", "Radev", 1500.98, "Sales");

            Developer gatakka = new Developer(11072, "Ivanka", "Vankova", 3000, "Production");
            Developer vili = new Developer(11073, "Vilizar", "Markovski", 3000, "Production");
            Developer peshev = new Developer(11071, "Mario", "Peshev", 4000, "Production");            
            Developer nakov = new Developer(11071, "Svetlin", "Nakov", 4000, "Production");
            nakov.AddProjects("Softuni game", DateTime.Now, "Softuni", "open");
            nakov.CloseProject("Softuni game");
            peshev.AddProjects("Wordpress plugin", DateTime.Now, "Wordpress", "open");

            Customer andi = new Customer(1234, "Andilei", "Reins");
            Customer meri = new Customer(1234, "Meriam", "Topkins");

            Purchases laptopLenovo = new Purchases("Laptop Lenovo", DateTime.Now, 1000);
            Purchases laptopHP = new Purchases("Laptop HP", DateTime.Now, 13500);
            Purchases laptopAcer = new Purchases("Laptop Acer", DateTime.Now, 765);
            Purchases laptopDell = new Purchases("Laptop Dell", DateTime.Now, 876);           

            andi.AddPurchase(laptopLenovo);
            andi.AddPurchase(laptopHP);
            radi.AddSales(laptopAcer);
            radi.AddSales(laptopDell);            
            pesho.AddSales(laptopLenovo);
            pesho.AddSales(laptopHP);

            List<Employee> employeeNakov = new List<Employee>() { pesho, peshev };

            svetlio.AddEmployeeUnderHisComand(employeeNakov);

            List<Person> peoples = new List<Person>()
                                                    {
                                                        svetlio,
                                                        pesho,
                                                        radi,
                                                        gatakka,
                                                        vili,
                                                        peshev,
                                                        nakov,
                                                        andi, 
                                                        meri
                                                    };
            foreach (var people in peoples)
            {
                Console.WriteLine(people.ToString());
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }
    }
}
