using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversionApp
{
    class PrimeTest
    {
        public static void TestNumberForPrimeStatus()
        {

            long numberToTest;
            long i = 2;
            Console.WriteLine("Please Enter Number to Test");

            //User Input Error Testing Needs Implemenation 
            numberToTest = long.Parse(Console.ReadLine());

            //Set Initial Value
            long maximumToTest = numberToTest;


            //Special Cases - 0, 1, and 2

            if (numberToTest == 0)
            {
                Console.Write("You can't test zero!!! Clearly not divisible by itself!");
            }
            if (numberToTest == 1)
            {
                Console.WriteLine("Kind of an odd one eh? One is divisible by one and itself, but that is itself, so .... yeah. Not prime");
            }

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            //for (i = 3; i < maximumToTest; i++)
            for (i = 3; i < maximumToTest; i += 2)
            {
                if (numberToTest % 2 == 0)
                {
                    if (numberToTest == 2)
                    {
                        Console.WriteLine("There are no prime numbers lower than this one! Fun fact: Only even prime number!");
                    }
                    else
                    {
                        Console.WriteLine($"Your number is NOT Prime! It's lowest prime factor is 2");
                        break;
                    }
                }
                else
                {
                    maximumToTest = numberToTest / i;

                }
            }
            if (i >= maximumToTest)
            {
                Console.WriteLine("Your Number is Prime!");

                Console.Write($"{i}\n\n");
                watch.Stop();
                Console.Write($"\n\nExecution Time: {watch.ElapsedMilliseconds} ms\n\n");
                Console.Write($"\n\nExecution Time: {watch.ElapsedTicks} ticks\n\n");

            }
            if (numberToTest == 69)
            {
                Console.WriteLine("Wink, Wink!");
            }

        }




    }







    //To Do - For User Input Error Checking
    //public static void CheckUserInput()
    //{
    //    throw new NotImplementedException();
    //}

}

