using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCalc
{
    class Program
    {
        static void Main()
        {
            Graphics.Intro();
            int choice = Graphics.DrawMenu();

            while (choice == 1)
            {
                Console.WriteLine("Choice 1");       
            }

            while (choice == 2)
            {
                Console.WriteLine("Choice 2");
            }

            Console.ReadKey();
        }

    }
}
