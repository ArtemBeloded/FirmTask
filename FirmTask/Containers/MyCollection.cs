using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask.Containers
{
    public class MyCollection<T> : List<T>
    {

        public static MyCollection<T> operator +(MyCollection<T> collection, T value)
        {
            collection.Add(value);
            return collection;
        }

        public static MyCollection<T> operator -(MyCollection<T> collection, T value) 
        {
            collection.Remove(value);
            return collection;
        }

    }
}
