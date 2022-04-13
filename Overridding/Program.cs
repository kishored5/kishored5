using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridding
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager() { Id = 1, Name = "Hari Hara", Salary = 2000000, Project = "C#" };

            //manager.Work();   //manager's work

            //TestEmployee(manager);  //manager's work

            //Accountant a = new Accountant() { Name = "Durga" };
            //a.Work();  //account's work
            //TestEmployee(a); //employee's work
            manager.AddToTeam(new Accountant() { Name = "siva" });
            manager.AddToTeam(new Employee() { Name = "LAkshmi" });
            Employee e = manager;
            e = Work();
            Console.WriteLine(e);
        }

        public static void TestEmployee(Employee e)
        {
            e.Work();
        }
    }
}
