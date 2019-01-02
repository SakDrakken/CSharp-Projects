using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCalc
{
    class Graphics
    {
        public static string title = @"
        _______  _______  _______    _______  _______  _        _______ 
       (  ____ )(  ____ )(  ____ \  (  ____ \(  ___  )( \      (  ____ \
       | (    )|| (    )|| (    \/  | (    \/| (   ) || (      | (    \/
       | (____)|| (____)|| |        | |      | (___) || |      | |      
       |     __)|  _____)| | ____   | |      |  ___  || |      | |      
       | (\ (   | (      | | \_  )  | |      | (   ) || |      | |      
       | ) \ \__| )      | (___) |  | (____/\| )   ( || (____/\| (____/\
       |/   \__/|/       (_______)  (_______/|/     \|(_______/(_______/
 ";


        public static void Intro()
        {
            Console.WriteLine(title);
            Console.WriteLine("version 0.1.1b - Eastern Bloc Productions (c) 2018 - GNU/GPL protected");   
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();

        }

        public static int DrawMenu()
        {
            int choice = 1;
            Console.Clear();
            DrawChoices(choice);
            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        choice = 1; DrawChoices(choice); break;
                    case ConsoleKey.DownArrow:
                        choice = 2; DrawChoices(choice); break;
                    case ConsoleKey.Enter:
                        return choice;
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Environment.Exit(0);
            return 0;
            
        }

        public static void DrawChoices(int choice)
        {
            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("> 1. Run with player imported values");
                Console.WriteLine("2. Run with premade generated values");
                Console.WriteLine("ESC - End program");
            }
            if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("1. Run with player imported values");
                Console.WriteLine("> 2. Run with premade generated values");
                Console.WriteLine("ESC - End program");
            }
        }

    }
}
