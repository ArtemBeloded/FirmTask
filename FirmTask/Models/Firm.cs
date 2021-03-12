using FirmTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    public class Firm
    {
        public EmployeeCollection<BaseEmployee> employeeCollection { get; set; }

        public Firm()
        {
            employeeCollection = new EmployeeCollection<BaseEmployee>();
        }
    }
}
