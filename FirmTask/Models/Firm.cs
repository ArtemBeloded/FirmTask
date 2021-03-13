using FirmTask.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    public class Firm
    {
        public MyCollection<BaseEmployee> Employees;

        public Firm()
        {
            Employees = new MyCollection<BaseEmployee>();
        }
    }
}
