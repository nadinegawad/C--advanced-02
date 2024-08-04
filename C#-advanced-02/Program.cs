using System.Collections;

namespace C__advanced_02
{
    internal class Program
    {

        public static int SumArrayList(ArrayList arr)
        {
            int sum = 0;
            if (arr is not null)
            {
                for(int i = 0; i < arr.Count; i++)
                {
                    sum +=(int) arr[i];
                }
            }
            return sum;
        }

        public static int SumAList(List<int> arr)
        {
            int sum = 0;
            if (arr is not null)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    sum += (int)arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList arrayList= new ArrayList();
            //Console.WriteLine($"Count:{arrayList.Count} :: Capacity:{arrayList.Capacity}");

            //arrayList.Add(1);
            //Console.WriteLine($"Count:{arrayList.Count} :: Capacity:{arrayList.Capacity}");

            //arrayList.AddRange(new int[] {2,3,4,5 });
            //Console.WriteLine($"Count:{arrayList.Count} :: Capacity:{arrayList.Capacity}");

            //ArrayList arrayList = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count:{arrayList.Count} :: Capacity:{arrayList.Capacity}");

            //arrayList.Add(6);
            //Console.WriteLine($"Count:{arrayList.Count} :: Capacity:{arrayList.Capacity}");

            //arrayList.TrimToSize();
            //Console.WriteLine($"Count:{arrayList.Count} :: Capacity:{arrayList.Capacity}");

            //arrayList.Add("amr");

            //foreach(int item  in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //int result= SumArrayList(arrayList);
            // Console.WriteLine(result);

            #endregion

            #region List
            //List<int> list = new List<int>();
            //list.Add(1);
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");

            //list.AddRange(new int[] { 2, 3, 4, 5 });
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");

            //list.TrimExcess();
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");

            //List<int> list = new List<int>(5) { 1, 2, 3, 4, 5 };

            //int Result=SumAList(list); 
            //Console.WriteLine(Result);

            #endregion

            #region List Methods
            //List<int> list = new List<int>(4) { 1, 2, 3, 4 };
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");
            ////add
            //list.Add(5);
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");

            ////addrange
            //list.AddRange(new int[] { 6, 7 });
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");

            //Insert
            //list.Insert(1,8);

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //InsertRange

            //list.InsertRange(0,new int[]{ 11,12});
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");


            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //binary serach

            //List<int> list = new List<int>() { 1, 2, 3, 4 ,5,6,7,8,9};
            //int index= list.BinarySearch(3);
            //Console.WriteLine(index);

            //Clear

            ////list.Clear();
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");


            ////Contains
            //Console.WriteLine(list.Contains(3));

            //copyTo


            //int[] arr = new int[10];
            ////list.CopyTo(arr);

            ////list.CopyTo(arr, 2);

            //list.CopyTo(1, arr, 3, 4);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //EnsureCapacity
            //List<int> list = new List<int>() { 1, 2, 3, 4 };

            //list.EnsureCapacity(4);
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");
            //list.EnsureCapacity(10);
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");
            //list.EnsureCapacity(2);
            //Console.WriteLine($"Count:{list.Count} :: Capacity:{list.Capacity}");

            //IndexOf
            //LastIndexOf

            //List<int> list = new List<int>() { 1,9, 2, 3 ,1,9 };
            //int index = list.IndexOf(9);
            //Console.WriteLine(index);
            //int lastIndex = list.LastIndexOf(9);
            //Console.WriteLine(lastIndex); 
            #endregion

            #region LinkedList
            //LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.AddFirst(1);
            //linkedList.AddLast(2);
            ////LinkedListNode < int > afterNode= linkedList.Find(1);
            //linkedList.AddAfter(linkedList.Find(1),5);
            //linkedList.AddBefore(linkedList.Find(2),10);
            //foreach(int i in linkedList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"Count:{linkedList.Count}"); 
            #endregion

            #region Stack

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);


            ////Console.WriteLine(stack.Peek());
            //Console.WriteLine("=============");
            //Console.WriteLine(stack.Pop());
            ////Console.WriteLine(stack.Pop());
            //Console.WriteLine("=============");
            ////bool Result = stack.TryPop(out int element);
            ////Console.WriteLine(element);
            //Console.WriteLine("=============");
            //stack.TryPeek(out int element);
            //Console.WriteLine(element);
            //foreach (int i in stack){
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            ////Console.WriteLine(queue.Peek());
            ////Console.WriteLine("===============");
            //bool Result = queue.TryDequeue(out int element);
            //Console.WriteLine(Result);
            //Console.WriteLine(element);
            //Console.WriteLine("===============");

            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

        }
    }
}
