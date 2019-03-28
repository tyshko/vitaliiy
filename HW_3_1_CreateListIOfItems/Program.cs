using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_1_CreateListIOfItems
{
        public static class Program
        {
            private static int output;
            private static string input;

            public static void Main(string[] args)
            {
                List<int> list = new List<int>();

                Console.WriteLine($"TASK1");
                Console.WriteLine($"Please enter int item to the list (enter 'stop' to finish):");

                list = InputList();
                Console.WriteLine($"Your list is:");
                OutputList(list);

                // Reversing ascending list in ArrayList == descending list   
                list.GetDescendingList();
                Console.WriteLine($"Your sorted descending list is:");

                // Displaying the elements in myList 
                OutputList(list);
                Console.Write($"Your short list is:\n");

                list.RemoveAllExceptFirstAndLast();
                OutputList(list);

                Console.ReadKey();
            }
            private static int IsInt() // Checking that input is int
            {
                input = Console.ReadLine();
                if (!int.TryParse(input, out output) & input != "stop")
                {
                    Console.WriteLine($"Entered value is not an int. Please enter a number:");
                }
                return output;
            }
            public static void OutputList(List<int> list)
            {
                Console.Write($"{string.Join(" ", list)}\n");
            }
            public static void GetDescendingList(this List<int> arr)
            {
                arr.Sort();
                arr.Reverse();
            }
            public static void RemoveAllExceptFirstAndLast(this List<int> arr)
            {
                if (arr.Count > 2)
                    arr.RemoveRange(1, arr.Count - 2);
            }
            public static List<int> InputList()
            {
                var arrayList = new List<int>();
                do
                {
                    IsInt();  // if TryParse
                    if (output != 0)
                    {
                        arrayList.Add(output);
                    }
                } while (input != "stop");
                return arrayList;
            }
    }
}


