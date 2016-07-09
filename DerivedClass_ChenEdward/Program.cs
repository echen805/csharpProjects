using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_ChenEdward
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employee.ReportHeader());

            Manager Manager1 = new Manager();
            Console.WriteLine(Manager1);
            //Console.WriteLine(Manager1.calculateBonus());
            SalesAssociate SalesAssc1 = new SalesAssociate();
            Console.WriteLine(SalesAssc1);
            Manager Manager2 = new Manager(102, "Carol", "Smith", DateTime.Parse("2/23/1993"), DateTime.Parse("9/5/2011"), 7580, 50, 500);
            Console.WriteLine(Manager2);
            Manager Manager3 = new Manager(103, "Bill", "Goode", DateTime.Parse("1/11/2004"), DateTime.Parse("3/12/2012"), 5600,0,0);
            Console.WriteLine(Manager3);
            SalesAssociate SalesAssc2 = new SalesAssociate(34, "Homer", "Grant", DateTime.Parse("5/1/1987"), DateTime.Parse("2/2/2011"), 4300, 15);
            Console.WriteLine(SalesAssc2);
            SalesAssociate SalesAssc3 = new SalesAssociate(211, "Elena", "Garcia", DateTime.Parse("4/4/1995"), DateTime.Parse("3/24/2007"), 3400, 5);
            Console.WriteLine(SalesAssc3);

            System.Collections.Generic.List<Employee> company = new System.Collections.Generic.List<Employee>();
            Console.WriteLine("\n Time for the foreach block printout");
            company.Add(Manager1);
            company.Add(Manager2);
            company.Add(Manager3);
            company.Add(SalesAssc1);
            company.Add(SalesAssc2);
            company.Add(SalesAssc3);

            foreach (Employee s in company)
            {
                Console.WriteLine(s); ;
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
