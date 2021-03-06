﻿using System;
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
                capacity = capacity * 2;
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
                    for (int j = i; j < count; j++)
                    {
                        items[j] = items[j + 1];
                        remover = true;
                        count--;
                    }
                }
                else
                {
                }
            }
            return remover;
        }

        public override string ToString()
        {
            string newString = "";

            newString = items[0].ToString();

            for(int i = 1; i < count; i++)
            {
                newString = newString + " " + items[i].ToString();
            }
            return newString;
        }

        private bool Contains(T item)
        {
            for (int i = 0;i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static CustomList<T> operator + (CustomList<T>list1, CustomList<T>list2)
        {
            CustomList<T> list3 = new CustomList<T>();

            if (list1 != null && list2 != null)
            {
                for(int i = 0; i < list1.count; i ++) 
                {
                    list3.Add(list1.items[i]);
                }
                for(int i = 0; i < list2.count; i++)
                {
                    list3.Add(list2.items[i]);
                }
            }
            return list3;
        }

        public static CustomList<T> operator - (CustomList<T>list1, CustomList<T> list2)
        {
           CustomList<T> list3 = new CustomList<T>();

            if(list1 != null && list2 != null)
            {
               for (int i = 0; i < list2.count; i++)
               {
                  if (!list1.Contains(list2[i]))
                  {
                     list3.Add(list2[i]);
                  }
               }
            }
            return list3;
        }

        public CustomList<T> Zip(CustomList<T>list1, CustomList<T>list2)
        {
            CustomList<T> result = new CustomList<T>();
            try
            {
                if (list1.count <= list2.count)
                {
                    for (int i = 0; i < list1.count; i++)
                    {
                        result.Add(list1[i]);
                        result.Add(list2[i]);
                    }
                    for (int j = result.count - 1; j < list2.count; j++)
                    {
                        result.Add(list2[j]);
                    }
                }
                else
                {
                    for (int i = 0; i < list2.count; i++)
                    {
                        result.Add(list1[i]);
                        result.Add(list2[i]);
                    }
                    for (int j = result.count - 1; j <= list1.count; j++)
                    {
                        result.Add(list1[j]);
                    }
                }
                return result;
            }
            catch(Exception)
            {
                throw new ArgumentNullException();
            }
        }

        public IEnumerator GetEnumerator()
        {
           for(int i = 0; i < count; i++)
           {
               yield return items[i];
           }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
