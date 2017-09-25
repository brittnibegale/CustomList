using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            //CustomList<int> list = new CustomList<int>() {1,2,3};
            //foreach( int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            CustomList<int> result = list + list1;
        }
    }
}
