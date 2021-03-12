using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    public class Worker : BaseEmployee
    {

        public new void ToWork() 
        {
            Console.WriteLine("Release product");
        }

    }
}
