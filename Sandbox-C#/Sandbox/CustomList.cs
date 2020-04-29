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
        private readonly int count;  //for read-only count property
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


        // constructor (SPAWNER)
        public CustomList()
        {
            items = new T[4];
            count = 4;
            capacity = 4;

        }

        // member methods (CAN DO)

    }
}
