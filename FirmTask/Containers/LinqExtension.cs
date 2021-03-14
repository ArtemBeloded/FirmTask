using System.Collections.Generic;
using System.Linq;

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
