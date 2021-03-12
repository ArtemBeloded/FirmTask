using FirmTask.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask.Models
{
    public class EmployeeCollection<T>
    {
        public MyCollection<T> EpmloyeeContainer { get; set; }

        public EmployeeCollection()
        {
            EpmloyeeContainer = new MyCollection<T>();
        }
    }
}
