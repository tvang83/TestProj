using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;  //List array variable 
        private int count;  //for read-only count property
        private int capacity; // for capacity property
        //public int[] one = { 1, 3, 5 };
        public int[] two = { 2, 4, 6 };
        public int[] minusTwo = { 2, 1, 6 };
        public int listResults;
        public int listResultsOutput;
        public int minusListResults;

        List<int> one = new List<int>() { 1, 3, 5 };
        //List<int> two = new List<int>() { 2, 4, 6 };

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                items[index] = value;
            }
        }

        // constructor (SPAWNER)
        public CustomList()  
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
           // listResults = listResultsOutput;

        }

        // member methods (CAN DO)

        public void Add(T value) //what's being passed in when this method is called.  Need to add if statement to 
        {
            items[count] = value;
            count++;
        }

        public void Remove(T value) //passed in items to be removed from List 
        {
            items[count] = value;
            count--;
        }
        public override string ToString()  //change List items to string, this will throw an error with the UnitTest class ClassList<>
        {
            return items.ToString();
        }

        public static CustomList<T> operator+ (CustomList<T> one, CustomList<T> two)  //crete two lists with list values and overload + operator, combining two lists
        {
            CustomList<T> listResults = one + two;
            return listResults;
        }

        public static CustomList<T> operator- (CustomList<T> one, CustomList<T> minusTwo)  //crete two lists with list values and overload + operator, combining two lists
        {
            CustomList<T> minusListResults = one - minusTwo;
            return minusListResults;
        }
    }
}
