using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    public class Worker : BaseEmployee
    {
        public double Experience { get; set; }

        public string FullName { get; set; }

        public new void ToWork() 
        {
            Console.WriteLine("Release product");
        }

        public new void About() 
        {
            Console.WriteLine("Full name - {0}, experience - {1}, type employee - {2}", FullName, Experience, "Worker");
        }
    }
}
