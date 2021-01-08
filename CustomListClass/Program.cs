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

            Console.WriteLine(newList.ToString());
            Console.ReadLine();

            CustomList<int> one = new CustomList<int>();
            one.CustomAdd(1);
            one.CustomAdd(3);
            one.CustomAdd(5);

            CustomList<int> two = new CustomList<int>();
            two.CustomAdd(2);
            two.CustomAdd(4);
            two.CustomAdd(6);

            Console.WriteLine(one + two);
            Console.ReadLine();
        }
    }
}
