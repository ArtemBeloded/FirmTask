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

        public override string ToString()
        {
            return string.Format("Full name: {0}, experience: {1}, type employee: {2}", FullName, Experience, "Worker");
        }
    }
}
