using System.Collections;
using System.Collections.Immutable;
using System.Linq.Expressions;

namespace Assigment02_ADV_C_
{
    internal class Program
    {
        #region Palindrome
        //static string IsPalindrome(int[] Arr, int Size)
        //{
        //    for (int i = 0; i < Size; i++)
        //    {
        //        for (int j = Size - 1 - i; j >= 0; j--)
        //        {
        //            if (Arr[i] != Arr[j]) 
        //            {
        //                return "Not Palindrome"; 
        //            }
        //            break; 
        //        }
        //    }

        //    return "Palindrome"; 
        //} 
        #endregion

        #region implement a function to reverse the elements of a queue using a stack
        //public static void ReverseQueue(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();

        //    while(queue.Count>0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }

        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }


        //} 
        #endregion

        #region parentheses is balanced using a stack.
        //public static bool BalancedParentheses(char[] parentheses)
        //{
        //    Stack<char> stack = new Stack<char>();

        //    foreach (char c in parentheses)
        //    {
        //        if (c == '(' || c == '{' || c == '[')
        //        {
        //            stack.Push(c);
        //        }
        //        else if (c == ')' || c == '}' || c == ']')
        //        {
        //            if (stack.Count == 0)
        //            {
        //                return false;
        //            }

        //            char top = stack.Pop(); 

        //            if ((c == ')' && top != '(') ||
        //                (c == '}' && top != '{') ||
        //                (c == ']' && top != '['))
        //            {
        //                return false; 
        //            }
        //        }
        //    }

        //    return true;
        //} 
        #endregion

        #region remove all odd numbers from it.
        //public static List<int> Duplication(int[] Arr)
        //{
        //    List<int> Duplicat = new List<int>(Arr);

        //    for (int i = 0; i < Duplicat.Count; i++)
        //    {
        //        for (int j = i + 1; j < Duplicat.Count; j++)
        //        {
        //            if (Duplicat[i] == Duplicat[j])
        //            {
        //                Duplicat.RemoveAt(j);
        //                j--;
        //            }
        //        }
        //    }
        //        return Duplicat;
        //}

        #endregion

        #region Q8: search for a target integer in the stack
        //public static string FindingCount(Stack<int> stack,int Target)
        //{
        //    int Count = 0;

        //    int StackCount = stack.Count;

        //    if (stack.Count == 0)
        //        return "The stack is empty";

        //    while (stack.Count > 0)
        //    {
        //        int Pooped = stack.Pop();
        //        if (Pooped==Target)
        //            break;

        //        Count++;
        //    }

        //    if(StackCount == Count)
        //        return "The target is not found";

        //    return $"The number of elements popped before finding the target is {Count}";

        //} 
        #endregion

        #region Q9:find their intersection
        //public static int[] Intersaction(int[] Arr1, int[] Arr2)
        //{
        //    List<int> Result = new List<int>();
        //    for (int i = 0; i < Arr1.Length-1; i++)
        //    {
        //        for (int j = 0; j < Arr2.Length-1; j++)
        //        {
        //            if (Arr1[i] == Arr2[j])
        //            {
        //                if (Arr1[i]== Arr2[j + 1])
        //                {
        //                    Result.Add(Arr1[i]);
        //                }

        //            }
        //        }
        //    }
        //    return Result.ToArray();
        //} 
        #endregion

        #region Q11:reverse first K elements of a queue
        //public static Queue<int> Reverse(Queue<int> queue, int Target)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    Queue<int> result = new Queue<int>();

        //    for (int i = 0; i < Target; i++)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }

        //    while (stack.Count > 0)
        //    {
        //        result.Enqueue(stack.Pop());
        //    }

        //    while (queue.Count > 0)
        //    {
        //        result.Enqueue(queue.Dequeue());
        //    }

        //    return result;
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Given an array  consists of  numbers with size N and number of queries
            //    int Size, NoOfQueries;

            //    bool Flag;

            //    do
            //    {
            //        Console.WriteLine("Enter the size of the array");
            //        Flag = int.TryParse(Console.ReadLine(), out Size);
            //    } while (!Flag);

            //    do
            //    {
            //        Console.WriteLine("Enter the number of queries");
            //        Flag = int.TryParse(Console.ReadLine(), out NoOfQueries);
            //    } while (!Flag);

            //    int[] Arr = new int[Size];

            //    Console.WriteLine("Enter the Numbers");

            //    for (int i = 0; i < Size; i++)
            //    {
            //        Arr[i]= int.Parse(Console.ReadLine());
            //    }

            //    int Count = 0;

            //    for (int i = 0; i < NoOfQueries; i++)
            //    {
            //        Console.WriteLine("Enter the query");
            //        int Query = int.Parse(Console.ReadLine());
            //        for (int j = 0; j < Size; j++)
            //        {
            //            if (Arr[j] > Query)
            //            {
            //                Console.WriteLine($"{Arr[j]}");
            //                Count++;
            //            }
            //        }

            //    } 
            #endregion

            #region Palindrome
            //int Size;

            //bool Flag;

            //do
            //{
            //    Console.WriteLine("Enter the size of the array");
            //    Flag = int.TryParse(Console.ReadLine(), out Size);
            //} while (!Flag);

            //int[] Arr = new int[Size];

            //Console.WriteLine("Enter the Numbers");

            //for (int i = 0; i < Size; i++)
            //{
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}

            //string Result=IsPalindrome(Arr, Size);

            //Console.WriteLine(Result); 
            #endregion

            #region implement a function to reverse the elements of a queue using a stack
            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);


            //ReverseQueue(queue);

            //foreach(int i in queue)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion

            #region parentheses is balanced using a stack.
            //char[] parentheses = { '{', '[', '(', ')', ']', '}' };

            //bool Result = BalancedParentheses(parentheses);

            //if (Result)
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //} 
            #endregion

            #region remove all odd numbers from it.
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3 };

            //Array.Sort(Arr);

            //List<int> Duplicat = Duplication(Arr);

            //foreach (int i in Duplicat)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion

            #region queue that can hold different data types
            //GQueue queue = new GQueue();

            //queue.Enqueue(1);
            //queue.Enqueue("Ahmed");
            //queue.Enqueue(2.2); 
            #endregion

            #region Q8: search for a target integer in the stack
            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine("Enter the target");

            //int Target;
            //bool Flag;

            //do
            //{
            //    Flag = int.TryParse(Console.ReadLine(), out Target);
            //} while (!Flag);


            //string Result = FindingCount(stack,Target);

            //Console.WriteLine(Result); 
            #endregion

            #region Q9:find their intersection
            //int[] Arr1 = { 1, 2, 3, 4, 5, 6, 7, 8,8, 9 };

            //int[] Arr2 = { 1, 2, 3, 4, 5, 6, 7, 8,8, 9 };

            //int[] Result = Intersaction(Arr1, Arr2);

            //foreach (int i in Result)
            //{
            //    Console.Write($"{i} ");

            //} 
            #endregion

            #region Q11:reverse first K elements of a queue
            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 7, 5 });

            //Queue<int> Result = Reverse(queue, 3);

            //foreach (int i in Result)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion



        }
    }
}
