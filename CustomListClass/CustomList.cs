﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        // MEMBER VARIABLES (HAVE A)
        // List<int> testList = new List<int>();
        private T[] holdingArray;
        private T[] tempArray;
        private int capacity;
        private int count;
        private int j;
        // PROPERTIES (GET:SET)
        public T this[int i] // indexer
        {
            get => holdingArray[i];
            set => holdingArray[i] = value;

        }
        public int Capacity // property
        {
            get => capacity;
        }
        public int Count  // property
        {
            get => count;
        }
        // CONSTRUCTOR (SPAWNER)
        public CustomList()
        {
            j = 4;
            holdingArray = new T[j]; // need a generic because a list could hold any object of the same type.
            capacity = 4;
            count = 0;
        }
        // MEMBER METHODS ( CAN DO )
        public void CustomAdd(T itemToAdd)
        {
            bool isNull = false;
            while(isNull == false)
            {
                
                for (int i = 0; i < holdingArray.Length; i++)
                {
                    if(holdingArray[i] == null ||  Convert.ToInt32(holdingArray[i]) == 0)
                    {
                        holdingArray[i] = itemToAdd;
                        isNull = true;
                        count++;
                        break;
                    }
                    else if(holdingArray[i] != null || Convert.ToInt32(holdingArray[i]) == 0) // reExamine what is happening here
                    {
                        
                    }
                    if(i == holdingArray.Length - 1)
                    {
                        tempArray = new T[j];
                        for (int temp = 0; temp < holdingArray.Length; temp++)
                        {
                            tempArray[temp] = holdingArray[temp];
                        }
                        j *= 2;
                        capacity *= 2;
                        holdingArray = new T[j];
                        for (int holding = 0; holding < tempArray.Length; holding++)
                        {
                            holdingArray[holding] = tempArray[holding];
                        }
                    }
                }
            }
        }
        public void CustomRemove(T itemToRemove)
        {
            // MEMBER VARIABLE ( HAVE A )
            tempArray = new T[j];
            T itemForRemove = itemToRemove;
            int k = 0;
            int capacitySetter;
            // PROPERTIES ( GET : SET )

            // CONSTRUCTOR ( SPAWNER )


            // MEMBER METHOD ( CAN DO )
            for (int i = 0; i < holdingArray.Length; i++)
            {
                if (Convert.ToInt32(holdingArray[i]) == Convert.ToInt32(itemForRemove))
                {
                    count -= 1;
                    // itemForRemove = default(T);
                }

                else if(Convert.ToInt32(holdingArray[i]) != Convert.ToInt32(itemForRemove))
                {
                    tempArray[k] = holdingArray[i];
                    k++;
                }
                
            }
            capacitySetter = count / 4;
            if (capacitySetter <= 1)
            {
                capacitySetter = 4;
            }
            else if (capacitySetter >= 2)
            {
                capacitySetter *= 4; 
            }
            holdingArray = new T[capacitySetter];

            for (int i = 0; i < holdingArray.Length; i++)
            {
                holdingArray[i] = tempArray[i];
            }
            capacity = capacitySetter;
        }
    }

}
