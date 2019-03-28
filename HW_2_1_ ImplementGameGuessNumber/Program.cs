using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1__ImplementGameGuessNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine("Please, input one number: ");
            int output = 0;
            do
            {
                output = EnterAndVerifyIsInt();
                if (output > randomNumber)
                {
                    Console.WriteLine("Your number is greater. Enter the less number:");
                }
                else if (output < randomNumber)
                {
                    Console.WriteLine("Your number is less. Enter the greater number:");
                }
            } while (output != randomNumber);
            Console.WriteLine("You won!");
        }

        private static int EnterAndVerifyIsInt()
        {
            int output;
            while (!int.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("Please enter int ");
            }
            return output;
        }
    }
}
