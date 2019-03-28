using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_Create_ConsoleApplicationTakes5numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LengthArr = 5;
            int[] arr = new int[LengthArr];
            var output = 0;

            Console.WriteLine($"Please enter {LengthArr} numbers");

            for (int i = 0; i < arr.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out output))
                {
                    Console.WriteLine("Please enter int");
                }
                arr[i] = output * 10;
            }

            Console.WriteLine("User input finished.Processing...");

            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.ReadLine();
        }
    }
}
