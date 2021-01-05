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
            newList.CustomAdd(16);

            Console.ReadLine();
        }
    }
}
