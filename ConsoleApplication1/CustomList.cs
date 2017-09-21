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
            item = new T[2];
        }
        public int Count(CustomList<T>list)
        {
            int count = 1;
            return count;
        }

        public void Capacity()
        {

        }
        public void Add(T item)
        {
            //item+=item[i]
        }

        public bool Remove(T item)
        {
            bool remover = true;
            return remover;
        }

    }
}
