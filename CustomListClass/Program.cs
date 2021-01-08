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
            newList.CustomAdd(10);
            newList.CustomAdd(20);
            newList.CustomAdd(1);
            newList.CustomAdd(5);
            newList.CustomRemove(10);
            newList.CustomAdd(16);

            Console.WriteLine(newList.Count);
            Console.WriteLine(newList.Capacity);

            Console.WriteLine(newList.ToString());  // override ToString()
            Console.ReadLine();

            CustomList<int> one = new CustomList<int>();
            one.CustomAdd(1);
            one.CustomAdd(3);
            one.CustomAdd(5);

            CustomList<int> two = new CustomList<int>();
            two.CustomAdd(2);
            two.CustomAdd(4);
            two.CustomAdd(6);

            Console.WriteLine(one + two);       // overload + operator
            Console.ReadLine();

            CustomList<int> newOne = new CustomList<int>();
            newOne.CustomAdd(1);
            newOne.CustomAdd(3);
            newOne.CustomAdd(5);

            CustomList<int> newTwo = new CustomList<int>();
            newTwo.CustomAdd(2);
            newTwo.CustomAdd(1);
            newTwo.CustomAdd(6);

            Console.WriteLine(newOne - newTwo);  // overload - operator
            Console.ReadLine();

            CustomList<int> odd = new CustomList<int>();
            odd.CustomAdd(1);
            odd.CustomAdd(3);
            odd.CustomAdd(5);

            CustomList<int> even = new CustomList<int>();
            even.CustomAdd(2);
            even.CustomAdd(4);
            even.CustomAdd(6);

            Console.WriteLine(odd.Zip(even)); // zip odd and even
            Console.ReadLine();
        }
    }
}
