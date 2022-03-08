using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversionApp.Menu
{
    class PrimeCheckMenu
    {

        public static void MenuOneDisplay(bool clearScreen)
        {
            if (clearScreen)
            {
                PrimeCheckMenu.HeadingGraphic(true);
                Console.WriteLine("1. Check a Number");
                Console.WriteLine("2. Exit");
                PrimeCheckMenu.FootingGraphic();

            }
            else
            {
                Console.WriteLine("1. Check a Number");
                Console.WriteLine("2. Exit");
            }
        }
        public static void HeadingGraphic(bool clear)

        {
            if (clear)
            {
                Console.Clear();
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------Welcome to Prime Number Test--------------");
            Console.WriteLine("----------------------------------------------------");
        }
        public static void FootingGraphic()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
        }

        public static int MenuOneChoice()
        {
            int userMenuChoiceNumber = 0;
            int[] userMenuOptions = new int[2] { 1, 2 };
            do
            {
                try
                {
                    userMenuChoiceNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    PrimeCheckMenu.HeadingGraphic(false);
                    Console.WriteLine(e.Message + "Please enter a valid option");
                    PrimeCheckMenu.FootingGraphic();
                    MenuOneDisplay(false);
                }
                if (!userMenuOptions.Contains(userMenuChoiceNumber))
                {
                    PrimeCheckMenu.HeadingGraphic(true);
                    Console.WriteLine("\n\nInvalid Input, Please Choose 1 or 2\n\n");
                    PrimeCheckMenu.FootingGraphic();
                    MenuOneDisplay(false);

                }
            } while (!userMenuOptions.Contains(userMenuChoiceNumber));
            return userMenuChoiceNumber;
        }



    }
}
