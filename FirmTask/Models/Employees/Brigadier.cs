using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    public class Brigadier : BaseEmployee
    {
        public double Experience { get; set; }

        public string FullName { get; set; }

        public new void ToWork()
        {
            Console.WriteLine("Purchase of materials");
        }

        public new void About()
        {
            Console.WriteLine("Full name - {0}, experience - {1}, type employee - {2}", FullName, Experience, "Brigadier");
        }

        public void CheckingWorkers()
        {
            Console.WriteLine("Checking workers");
        }
    }
}
