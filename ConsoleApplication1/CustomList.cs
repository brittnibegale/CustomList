using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] item;
        public T this[int i]
        {
            get { return item[i]; }
            set { item[i] = value; }
        }

        public CustomList()
        {
            item = new T[3];
        }

        public void Add(T item)
        {

        }

    }
}
