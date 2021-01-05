using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        List<int> testList = new List<int>();
        private T[] holdingArray;
        private T[] tempArray;
        int j;
        public T actualResult;
        public CustomList()
        {
            j = 4;
            holdingArray = new T[j]; // need a generic because a list could hold any object of the same type.
        }

        public void CustomAdd(T itemToAdd)
        {
            bool isNull = false;
            while(isNull == false)
            {
                for (int i = 0; i < holdingArray.Length-1; i++)
                {
                    if(holdingArray[i] == null ||  Convert.ToInt32(holdingArray[i]) == 0)
                    {
                        holdingArray[i] = itemToAdd;
                        isNull = true;
                        break;
                    }
                    else if(holdingArray[i] != null)
                    {
                        i++;
                    }
                    if(i == holdingArray.Length - 1)
                    {
                        tempArray = new T[j];
                        for (int temp = 0; temp < holdingArray.Length - 1; i++)
                        {
                            tempArray[temp] = holdingArray[temp];
                        }
                        j *= 2;
                        holdingArray = new T[j];
                        for (int holding = 0; holding < tempArray.Length - 1; holding++)
                        {
                            holdingArray[holding] = tempArray[holding];
                        }
                        isNull = true;
                        break;
                    }
                }
            }
        }
    }

}
