using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask.Containers
{
    public static class MyCollectionExtension
    {
        public static bool IsContain(this IEnumerable<BaseEmployee> collection, BaseEmployee value) 
        {
            return collection.Contains(value);
        }
    }
}
