using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that asks the user to enter a number. 
             * Loop from 2 to 20 and multiply the loop value by the number the user 
             * entered and output the value each time.  When the loop is finished, output the sum of all previous values. 
             */

            double result = 0;


            for (double i = 2; i <= 20; i++)
            {
                Console.Write("Please enter a number: ");
                result = result * i;
                result += Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("The sum is: " + result);
            Console.ReadLine();
        }
    }
}
