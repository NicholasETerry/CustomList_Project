using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] holdingArray;
        private int capacity;
        private int count;
        public T this[int i]
        {
            get => holdingArray[i];
            set => holdingArray[i] = value;
        }
        public int Capacity
        {
            get => capacity;
        }
        public int Count
        {
            get => count;
        }
        public CustomList()
        {
            capacity = 4;
            count = 0;
            holdingArray = new T[capacity];
        }
        public void CustomAdd(T itemToAdd)
        {
            if(count == capacity)
            {
                ExtendArray(capacity * 2);
            }
            holdingArray[count] = itemToAdd;
            count++;
        }
        public void ExtendArray(int capacityNeeded)
        {
            T[] temp = new T[capacityNeeded];
            holdingArray = CopyArray(temp);
            capacity = capacityNeeded;
        }
        public void Trim()
        {
            ExtendArray(count);
        }
        public T[] CopyArray(T[] arrayToGetValue)
        {
            for (int temp = 0; temp < count; temp++)
            {
                arrayToGetValue[temp] = holdingArray[temp];
            }
            return arrayToGetValue;
        }
        public bool CustomRemove(T itemToRemove)
        {
            int k = 0;
            bool isRemoved = false;
            for (int i = 0; i < count; i++)
            {
                if(isRemoved == false && holdingArray[i].Equals(itemToRemove) == true)
                {
                    isRemoved = true;                    
                }
                else
                {
                    holdingArray[k] = holdingArray[i];
                    k++;
                }
            }
            if(isRemoved == true)
            {
                count--;
            }
            return isRemoved;
        }
        public override string ToString()
        {
            string itemToString = "";
            for (int i = 0; i < count; i++)
            {
               itemToString += holdingArray[i].ToString();
            }
            return itemToString;
        }
        public static CustomList<T> operator + (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList <T> result = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                result.CustomAdd(listOne[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                result.CustomAdd(listTwo[i]);
            }
            return result;
        }
        public static CustomList<T> operator - (CustomList<T> listOne, CustomList<T> listTwo)
        { 
            foreach (var item in listTwo)
            {
                if(listOne.Contains(item))
                {
                    listOne.CustomRemove(item);
                }
            }
            return listOne;
        }
        public CustomList<T> Zip(CustomList<T> evenZip)
        {          
            CustomList<T> Zipped = new CustomList<T>();
            for (int i = 0; i < count; i++)
            {
                Zipped.CustomAdd(holdingArray[i]);
                Zipped.CustomAdd(evenZip[i]);
            }
            return Zipped;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)holdingArray).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return holdingArray.GetEnumerator();
        }
    }

}
