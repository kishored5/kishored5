using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_RDP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Id = 46219;
            emp1.Name = "Kishore";
            emp1.salary = 500000;
            Employee emp2 = new Employee(){Id = 2, Name = "Kumar", salary = 100000};
            Employee emp3 = new Employee() { Id = 3, Name = "durga", salary = 200000};
            Testemployee(emp1);
        }

        private static void Testemployee(Employee emp)
        {
            emp.work();
            Console.WriteLine(emp.Info);
        }
    }
}
