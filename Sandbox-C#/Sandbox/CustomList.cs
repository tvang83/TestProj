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
        private  int count;  //for read-only count property
        private int capacity; // for capacity property

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
        }

        // member methods (CAN DO)

        public void Add(T value) //what's being passed in when this method is called.
        {
            items[count] = value;
            count++;
        }

        public void Remove(T value) //passed in items to be removed from List 
        {
            items[count] = value;
            count--;
        }
        //public override ChangeToString()  //change List items to string, this will throw an error with the UnitTest class ClassList<>
        //{
        //   return items.ToString();
        //}
    }
}
