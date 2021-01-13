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
            get
            {
                if (i <= count - 1 || i == 0) // Add conditional for out of range 
                {
                    return holdingArray[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                holdingArray[i] = value;
            }
        }
        public int Capacity                 // add set 
        {
            get => capacity;
            set => capacity = value;            
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
        public void Add(T itemToAdd)
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
        public bool Remove(T itemToRemove)
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
            StringBuilder itemToString = new StringBuilder(); // Using StringBuilder instead of adding a new char every time to a string var.
            for (int i = 0; i < count; i++)
            {
                itemToString.Append(holdingArray[i]);
            }
            
            return itemToString.ToString();
        }
        public static CustomList<T> operator + (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList <T> result = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                result.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                result.Add(listTwo[i]);
            }
            return result;
        }
        public static CustomList<T> operator - (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> result = new CustomList<T>(); // added result list for return instead of modifying listOne.
            foreach (var item in listTwo)
            {
                if(listOne.Equals(item)) // replaced Contains() with Equals()
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public CustomList<T> Zip(CustomList<T> evenZip) // allow for unequal parameter list sizes
        {
            if (count.Equals(evenZip.count))
            {
                return ZipperEquals(evenZip);
            }
            else
            {
                return ZipperDoesnotEqual(evenZip);
            }
        }
        public CustomList<T> ZipperEquals(CustomList<T> inputToZip) // created zipperEquals method to handle logic
        {
            CustomList<T> Zipped = new CustomList<T>();
            for (int i = 0; i < count; i++)
            {
                Zipped.Add(holdingArray[i]);
                Zipped.Add(inputToZip.holdingArray[i]);
            }
            return Zipped;
        }
        public CustomList<T> ZipperDoesnotEqual(CustomList<T> inputToZip) // created zipperDoesntEqual method to handle logic
        {
            CustomList<T> Zipped = new CustomList<T>();
            if(count > inputToZip.count)
            {
                for (int i = 0; i < inputToZip.count; i++)
                {
                    Zipped.Add(holdingArray[i]);
                    Zipped.Add(inputToZip.holdingArray[i]);
                }
                for (int i = inputToZip.count; i < count; i++)
                {
                    Zipped.Add(holdingArray[i]);
                }
            }
            else if (count < inputToZip.count)
            {
                for (int i = 0; i < count; i++)
                {
                    Zipped.Add(holdingArray[i]);
                    Zipped.Add(inputToZip.holdingArray[i]);
                }
                for (int i = count; i < inputToZip.count; i++)
                {
                    Zipped.Add(inputToZip.holdingArray[i]);
                }
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
