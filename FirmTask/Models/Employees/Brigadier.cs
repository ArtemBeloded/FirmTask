using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    public class Brigadier : BaseEmployee
    {
        public new void ToWork()
        {
            Console.WriteLine("Purchase of materials");
        }

        public void CheckingWorkers()
        {
            Console.WriteLine("Checking workers");
        }

        public override string ToString()
        {
            return string.Format("Full name: {0}, experience: {1}, type employee: {2}", FullName, Experience, "Brigadier");
        }
    }
}
