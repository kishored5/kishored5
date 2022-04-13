using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridding
{
    class Manager:Employee
    {
        public string Project { get; set; }
        public Employee[] Team { get; set; } = new Employee[10];
        public int TeamSize { get; private set; }
        public void AddToTeam(Employee emp)
        {
            Team[TeamSize] = emp;
            TeamSize++;
        }
        public override void Work()
        {
            Console.WriteLine("Manager {0} works with a Team of {1} member on project {2}",Name,TeamSize,Project);
        }
    }
}
