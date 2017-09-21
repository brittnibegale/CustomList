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
        public int capacity;//create public properties
        public int count;// create public properties
        public T this[int i]
        {
            get { return item[i]; }
            set { item[i] = value; }
        }

        public CustomList()
        {
            item = new T[2];
            capacity = 4;
            count = 0;
        }
        public void Count(CustomList<T>list)
        {
            count = 1;
            
            //checkforcapacity
            
        }

        public void Capacity()
        {
            //keep capacity if count is below capacity or double capacity
            capacity = capacity * 2;
        }
        public void Add(T item)
        {
            //checkforcount
            
            //item+=item[i]
        }

        public bool Remove(T item)
        {
            bool remover = true;
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

        public void OverLoadPlus(CustomList<T>list1, CustomList<T>list2)
        {

        }

        public void OverLoadMinus(CustomList<T>list1, CustomList<T> list2)
        {

        }

        public void Zip(CustomList<T>list1, CustomList<T>list2)
        {

        }

    }
}
