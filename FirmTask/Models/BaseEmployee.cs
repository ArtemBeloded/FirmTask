using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    public abstract class BaseEmployee
    {
        public double Experience { get; set; }

        public string FullName { get; set; }

        public void ToWork() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
