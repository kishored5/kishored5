using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager
{
    class Manager : Employee
    {
        public string Project { get; set; }
        public Employee[] Team { get; set; } = new Employee[10];
        public int TeamSize { get; private set; }
        public void AddToTeam(Employee emp)
        {
            Team[TeamSize] = emp;
            TeamSize++;
        }
        public void Work()
        {
            Console.WriteLine("Manager {0} Works with a Team of {1} member on Project {2}", Name, TeamSize, Project);
        }
    }
}
