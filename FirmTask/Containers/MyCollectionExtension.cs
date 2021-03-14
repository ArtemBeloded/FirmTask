using System.Collections.Generic;
using System.Linq;

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
