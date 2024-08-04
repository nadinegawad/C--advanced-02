using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As_02
{

    //1.	Create a generic class named FixedSizeList<T>.
    internal class FixedSizeList<T>
    {
        //2.	Implement a constructor that takes the fixed capacity of the list as a parameter.
        public FixedSizeList(int _capacity)
        {
            Capacity = _capacity;
        }
        public int Capacity { get; set; }
        public List<T> list { get; set; }


        //3.	Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
        public void Add(T value)
        {
            if (list.Count >= Capacity)
            {
                throw new ArgumentException();
            }
            else
            {
                list.Add(value);
            }
        }

        //4.	Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
        public T GetValue(int index)
        {
            if (index < 0 || index >= list.Count) { throw new ArgumentOutOfRangeException(); }
            else
            {
                return list[index];
            }
        }
    }
}
