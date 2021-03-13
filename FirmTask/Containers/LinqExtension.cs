using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask.Containers
{
    public static class LinqExtension
    {
        public static int CountOfEmployee<T, R>(this MyCollection<T> employees) 
        {
            return employees.Count(x => x is R);
        }

        public static IEnumerable<T> GetEpm<T, R>(this MyCollection<T> employees)
        {
            return employees.Where(x => x is R);
        }
    }
}
