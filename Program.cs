using System.Collections;
using System.Collections.Generic;

namespace Demo2_C_ADV
{
    internal class Program
    {
        //public static void PrintArrayList(ArrayList list)
        //{

        //    foreach (int i in list)
        //    {
        //        Console.Write($"{i} ");
        //    }

        //}

        #region Non-Generic List Problems
        //public static int SumArrayList(ArrayList list)
        //{
        //    int Sum = 0;
        //    if (list is not null)
        //    {

        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] is int)
        //            {
        //                Sum += (int)list[i];
        //            }
        //        }
        //    }
        //    return Sum;
        //} 
        #endregion

        #region Generic-Lists List
        //public static void PrintList<T>(List<T> list)
        //{
        //    foreach (T item in list)
        //    {
        //        Console.Write($"{item} ");
        //    }
        //    Console.WriteLine();
        //}

        //public static int SumList(List<int> list)
        //{
        //    int sum = 0;
        //    foreach (int i in list)
        //    {
        //        sum += i;
        //    }

        //    return sum;

        //} 
        #endregion

        #region Generic-Lists LinkedList
        //public static void PrintLinkedList<T>(LinkedList<T> List)
        //{
        //    foreach (T item in List)
        //    {
        //        Console.Write($"<- {item} ->");
        //    }
        //    Console.WriteLine();
        //} 
        #endregion

        #region Generic-Lists Stack
        //public static void PrintStack(Stack<int> stack)
        //{
        //    foreach (int i in stack)
        //    {

        //        Console.Write($"{i} ");
        //    }
        //    Console.WriteLine();
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Non-Generic Array List

            //int[] Numbers = { 5, 4, 7, 5, 6, 3, 0, 4 };
            //ArrayList list = new ArrayList(Numbers);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //list.Add(1);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //list.Add(2);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //list.Add(2);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //list.Add(10);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //ArrayList list = new ArrayList();

            //list.Add(1);

            //Console.WriteLine($"Count: {list.Count} , Capacity:{list.Capacity}");


            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //Console.WriteLine($"Count: {list.Count} , Capacity:{list.Capacity}");

            //list.Add(5);

            //Console.WriteLine($"Count: {list.Count} , Capacity:{list.Capacity}");

            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[1]);

            //list.AddRange(new int[] {10,20,30});

            //PrintArrayList(list);

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 25, Salary = 18000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Khaled", Age = 29, Salary = 20000 };
            //Employee E03 = new Employee() { Id = 3, Name = "lobna", Age = 24, Salary = 14000 };
            //Employee E04 = new Employee() { Id = 4, Name = "yasmin", Age = 22, Salary = 12000 };

            //list.AddRange(new Employee[] { E01, E02, E03, E04 });


            ////int Index = list.BinarySearch(E01);
            ////int Index = list.BinarySearch(new Employee() { Name = "yasmin" }, new EmployeeComparerName());
            //int Index = list.BinarySearch(0,4,new Employee() { Name = "yasmin" }, new EmployeeComparerName());


            //Console.WriteLine(Index);

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //list.Clear();

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //Console.WriteLine(list.Contains(2));

            //int[] Arr=new int[10];

            ////list.CopyTo( Arr);

            ////list.CopyTo(Arr,3);

            //list.CopyTo(2,Arr,2, 2);



            //foreach (int i in Arr)
            //{

            //    Console.WriteLine(i);

            //}

            //int x=list.IndexOf(3,1);
            //int x = list.IndexOf(3, 1,2);


            //Console.WriteLine(x);

            //list.Insert(0, 4);

            //list.Insert(0,new int[] {1,2,3});

            //PrintArrayList(list); 
            #endregion

            #region Non-Generic List Problems
            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //int sum=SumArrayList(list);

            //Console.WriteLine(sum); 
            #endregion

            #region Generic-Lists List
            //List<int> list= new List<int>{ 1, 2, 3, 4 };

            //list.Add(5);
            //list.Add(6);

            //PrintList(list);

            //Console.WriteLine();

            //int Sum=SumList(list);

            //Console.WriteLine(Sum);

            //int i=list.BinarySearch(5);
            //Console.WriteLine(i);

            //List<Employee> list01=new List<Employee>();

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 25, Salary = 18000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Khaled", Age = 29, Salary = 20000 };
            //Employee E03 = new Employee() { Id = 3, Name = "lobna", Age = 24, Salary = 14000 };
            //Employee E04 = new Employee() { Id = 4, Name = "yasmin", Age = 22, Salary = 12000 };

            //list01.AddRange(new Employee[] { E01, E02, E03, E04 });

            ////int Index=list01.BinarySearch(E01);

            //int Index = list01.BinarySearch(E04, new EmployeeComparerName());

            //Console.WriteLine(Index); 
            #endregion

            #region Generic-Lists LinkedList
            //LinkedList<int> list = new LinkedList<int>();

            //list.AddLast(1);
            //list.AddFirst(2);

            ////PrintLinkedList(list);

            ////list.AddLast(3);

            ////PrintLinkedList(list);

            //LinkedListNode<int> node = new LinkedListNode<int>(3);

            //list.AddLast(node);

            //PrintLinkedList(list);

            //list.AddAfter(node, 4);

            //PrintLinkedList(list);

            //list.AddBefore(node, 5);

            //PrintLinkedList(list);

            //Console.WriteLine(list.First.Value);

            //Console.WriteLine(list.Last.Value);

            //Console.WriteLine(list.First.Next.Value);

            //list.Remove(5);

            //PrintLinkedList(list);

            //list.Remove(list.First);

            //PrintLinkedList(list);

            //list.RemoveLast();

            //PrintLinkedList(list); 
            #endregion

            #region Generic-Lists Stack
            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            ////Console.WriteLine(stack.Peek());

            //PrintStack(stack);

            //int Top=stack.Pop();

            //Console.WriteLine(Top);

            ////bool Flag = stack.TryPeek(out int top);

            ////Console.WriteLine(Flag);


            //bool Flag = stack.TryPop(out int top);

            //Console.WriteLine(Flag); 
            #endregion












        }
    }
}

