using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_RDP_Inheritance
{
    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double salary { get; set; }

        public void work()
        {
            Console.WriteLine("Employee {0}-{1} works for salary {2}",Id ,Name,salary);
        }
        public string Info
        {
            get
            {
                return string.Format("Employee\tId={0}\tName={1}\tsalary={2}", Id, Name, salary);
            }
        }
    }
}
