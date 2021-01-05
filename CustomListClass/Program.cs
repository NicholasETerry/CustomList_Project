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
            List<int> testList = new List<int>();
            int firstIndex = testList[0];
            Console.WriteLine(firstIndex);
            Console.ReadLine();
        }
    }
}
