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
    }
}
