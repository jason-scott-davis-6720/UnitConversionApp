using System;

namespace UnitConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int userMenuChoiceNumber;
            do
            { 
               userMenuChoiceNumber = Menu.PrimeCheckMenuTight.MenuOne(false);

                if (userMenuChoiceNumber == 1)
                {
                    PrimeTest.TestNumberForPrimeStatus();
                }
      
            } while (userMenuChoiceNumber == 1);




        }
    }
}
