using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> newList = new CustomList<int>();
            newList.Add(10);
            newList.Add(20);
            newList.Add(1);
            newList.Add(5);
            newList.Remove(10);
            newList.Add(16);

            Console.WriteLine(newList.Count);
            Console.WriteLine(newList.Capacity);
            Console.WriteLine(newList[16]); // out of range

            Console.WriteLine(newList.ToString());  // override ToString()
            Console.ReadLine();

            CustomList<int> one = new CustomList<int>();
            one.Add(1);
            one.Add(3);
            one.Add(5);

            CustomList<int> two = new CustomList<int>();
            two.Add(2);
            two.Add(4);
            two.Add(6);

            Console.WriteLine(one + two);       // overload + operator
            Console.ReadLine();

            CustomList<int> newOne = new CustomList<int>();
            newOne.Add(1);
            newOne.Add(3);
            newOne.Add(5);

            CustomList<int> newTwo = new CustomList<int>();
            newTwo.Add(2);
            newTwo.Add(1);
            newTwo.Add(6);

            Console.WriteLine(newOne - newTwo);  // overload - operator
            Console.ReadLine();

            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);

            Console.WriteLine(odd.Zip(even)); // zip odd and even
            Console.ReadLine();
        }
    }
}
