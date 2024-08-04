using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace As_02
{
    internal class Program
    {



        //1.You are given an ArrayList containing a sequence of elements of elements.
        public static void reverseArrayList(ArrayList list)
        {
            ArrayList newList = new ArrayList();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                newList.Add(list[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = newList[i];
            }
        }

        //2.	You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list
        public static List<int> AddEvenList(List<int> arr)
        {
            List<int> EvenList = new List<int>();
            if (arr is not null)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        EvenList.Add(arr[i]);
                    }
                }

            }
            return EvenList;
        }
        static void Main(string[] args)
        {

            //Part1======================================

            #region list<>
            //List<T> is a generic list based on an array that dynamically resizes as elements are added or removed.
            //List<int> numbers = new List<int>();
            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion

            #region linkedList
            //LinkedList<T> is a doubly linked list where each element is a separate node containing a value and references to the next and previous nodes.
            //don't based on array 
            //don't have capacity so it don't make new list 
            //LinkedList<string> linkedList = new LinkedList<string>();
            //linkedList.AddLast("anmr");
            //linkedList.AddLast("aya");
            //linkedList.AddLast("ahmed");

            //foreach (string item in linkedList)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Stack
            //Stack<T> represents a last-in, first-out (LIFO) collection of objects.
            //Stack<string> stack = new Stack<string>();
            //stack.Push("Item 1");
            //stack.Push("Item 2");
            //stack.Push("Item 3"); 
            #endregion

            #region Qeue
            //Queue<T> represents a first-in, first-out (FIFO) collection of objects.
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Item 1");
            //queue.Enqueue("Item 2");
            //queue.Enqueue("Item 3");
            #endregion

            //Part2======================================
            #region Q01
            //1.You are given an ArrayList containing a sequence of elements of elements.
            //ArrayList array = new ArrayList() { 1, 2, 3, 4, 5 };

            //    reverseArrayList(array);

            //    foreach(int i in array)
            //    {
            //        Console.WriteLine(i);
            //    }
            #endregion

            #region Q02
            //2.	You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list
            List<int> list = new List<int>() { 1, 2, 5, 3, 8, 12, 16, 9, 99, 2 };
            List<int> EvenList = AddEvenList(list);
            foreach(int item in EvenList)
            {
                Console.Write($" {item}");
            }
            #endregion
        }
    }
}
