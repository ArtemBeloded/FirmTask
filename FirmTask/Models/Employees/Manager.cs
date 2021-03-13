using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    public class Manager : BaseEmployee
    {
        public new void ToWork()
        {
            Console.WriteLine("Сollecting orders");
        }

        public void IssueOfAssignment() 
        {
            Console.WriteLine("Task issued");
        }

        public override string ToString()
        {
            return string.Format("Full name: {0}, experience: {1}, type employee: {2}", FullName, Experience, "Manager");
        }
    }
}
