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
        
            Console.WriteLine("Please Enter Number to Test");
            numberToTest = long.Parse(Console.ReadLine());

            Console.WriteLine(numberToTest);
            Console.ReadLine();


        }
        //public static void PrimeNumberTest(userNumber)
        //{
        //    int maxToCheck;
        //    int numberToCheck;




        //To Do - For User Input Error Checking
        public static void CheckUserInput()
        {
            throw new NotImplementedException();
        }

    }
}
