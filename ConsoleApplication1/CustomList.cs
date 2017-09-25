using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        public T[] items;
        //public T[] tempItems;
        public int capacity;
        int count;

        public int Count
        {
            get { return count; }
        }

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }
        
        public void Add(T item)
        {
            if (count < capacity)
            {
                items[count] = item;
                ++count;
            }
            else if (count >= capacity)
            {
                capacity = capacity * 2;// create own function for this
                count = 0;
                T[] tempItems = new T[capacity];
                foreach (T thing in items)
                {
                    tempItems[count] = thing;
                    ++count;
                }
                tempItems[count] = item;
                items = new T[capacity];
                ++count;
                items = tempItems;
                //count = 0;
                //foreach(T newItem in tempItems)
                //{
                //    items[count] = newItem;
                //    ++count;
                //}
            }
        }

        public bool Remove(T item)
        {
            bool remover = false;

            for (int i = 0; i < count; i++ )
            {
                if (items[i].Equals(item))
                {
                    items[i] = items[i + 1];
                    i++;
                    for(int j = i; j < count; j++)
                    {
                        items[j] = items[j + 1];
                        remover = true;
                    }
                }
            }
            return remover;
        }

        public override string ToString()
        {
            string input = "hi there";
            return input;
            // add to an array1 all the information 
            //add all indexes of array1 to the index0 of array2
            //convert if int = 2 then string of int = "n" where n=int
        }

        public static CustomList<T> operator + (CustomList<T>list1, CustomList<T>list2)
        {
            if (list1 != null && list2 != null)
            {
                foreach(T item in list2.items)
                {
                    list1.Add(item);
                }
            }
            return list1;
        }

        public static CustomList<T> operator - (CustomList<T>list1, CustomList<T> list2)
        {
            if(list1 != null && list2 != null)
            {
                foreach(T item in list2.items)
                {
                    list1.Remove(item);
                }
            }
            return list1;
        }

        public void Zip(CustomList<T>list1, CustomList<T>list2)
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
