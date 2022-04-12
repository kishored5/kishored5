using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager() { Id = 1, Name = "KKD", Salary = 20000,Project = "R&D" };
            Console.WriteLine("Id:" + manager.Id);
            Console.WriteLine("Name:" + manager.Name);
            Console.WriteLine("Salary:" + manager.Salary);
            Console.WriteLine("Project:" + manager.Project);
            manager.AddToTeam(new Employee() { Id = 2, Name = "narayana", Salary = 50000 });
            manager.AddToTeam(new Employee() { Id = 3, Name = "krishna", Salary = 70000 });
            manager.AddToTeam(new Employee() { Id = 4, Name = "siva", Salary = 90000 });
            manager.AddToTeam(new Employee() { Id = 5, Name = "govinda", Salary = 120000 });
            manager.AddToTeam(new Employee() { Id = 6, Name = "lakshmi", Salary = 150000 });

            Console.WriteLine("Team Size:" + manager.TeamSize);
            Console.WriteLine("Team member:");
            for (var i = 0; i < manager .TeamSize; i++)
            {
                Console.WriteLine("\t"+manager .Team[i].Name);
            }
            manager.Work();
            TestEmployee(manager);
        }

        private static void TestEmployee(Employee e)
        {
            e.Work();
        }
    }
}
