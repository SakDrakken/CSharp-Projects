using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_skola_domino_build1
{
    class MainProgram
    {
        static void Main()
        {
            int n = 0;
            bool nCheck = false;
            int[] piece1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] piece2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[,] placedPiece = new int[37,3];
            int x;
            int y;

            // getting the n count of pieces
            //using the double check
            while (nCheck == false)
            {
                Console.WriteLine("Enter number of pieces used (max 16):");
                string nCount = Console.ReadLine();

                Int32.TryParse(nCount, out n);

                if (Int32.TryParse(nCount, out n))
                {
                    if (n >= 1 && n <= 16)
                    {
                        Console.WriteLine("Value confirmed:" + n);

                        // confirming the check thereby disabling this while loop
                        nCheck = true;
                    }
                    else
                    {
                        Console.WriteLine("Value declined. Enter a new value.");
                    }
                }
                else
                {
                    Console.WriteLine("Value entered cannot be converted to integer. Enter a new valid value.");
                }
            }

            // Console.WriteLine("DEBUG: ");
            // Console.WriteLine(n);
            // Console.ReadKey();

            // getting the right values 
                for (int nLoop = 1; nLoop <= n; nLoop++)
                    {
                        Console.WriteLine("Declare the 1st side of " + nLoop + ". piece:");
                        string intx = Console.ReadLine();
                        Int32.TryParse(intx, out x);
                        Console.WriteLine("Declare the 2nd side of " + nLoop + ". piece:");
                        string inty = Console.ReadLine();
                        Int32.TryParse(inty, out y);

                        piece1[nLoop] = x;
                        piece2[nLoop] = y;
                        x = 0;
                        y = 0;

                    }
            //margin for debug output
                        Console.WriteLine("\n");
            //debug output
                    for (int nLoop = 1; nLoop <= n; nLoop++)
                        {
                            Console.WriteLine(piece1[nLoop] + piece2[nLoop] + "\n");
                        }

            //here starts the magic
            for (int tryMove = n; tryMove <= n; tryMove++)
            {
                if (piece1[tryMove] == piece2[tryMove + 1] || piece2[tryMove] == piece1[tryMove + 1] || piece1[tryMove + 1] == piece1[tryMove] || piece2[tryMove] == piece2[tryMove + 1])
                {
                    placedPiece[tryMove, 1] = piece1[tryMove];
                    placedPiece[tryMove, 2] = piece2[tryMove];
                }
            }
            for (int tryMove = 0; tryMove <= n; tryMove++)
            {
                Console.WriteLine(placedPiece[tryMove, 1] + placedPiece[tryMove, 2]);
            }
            Console.ReadKey();
        }
    }
}
