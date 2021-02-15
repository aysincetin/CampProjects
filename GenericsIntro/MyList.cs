using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        // contructor: the same as the name of the class and is created automatically
        // Shortcut for constructor: "ctor + tab tab"
        public MyList() //constructor
        {
            items = new T[0];  // reference type so need "new" key - An array with 0 elements created
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //temporary array reference holds the item array reference. So elements won't be lost.
            items = new T[items.Length + 1];    


            
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i]; 
            }
            items[items.Length - 1] = item; // The new element to be added is added here
        }
        public int Length
        {
            get { return items.Length; }
        }

    }
}
