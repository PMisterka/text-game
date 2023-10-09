using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CeltyckaPrzygoda

{
    class Start
    {
        public static void Game()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n=======================================");
            Console.WriteLine("\n           Celtycka przygoda           ");
            Console.WriteLine("\n=======================================");
            Console.WriteLine("\n");

            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nNaciśnij dowolny klawisz aby rozpocząć.");
            Console.ReadKey();
            Console.Clear();


        }
       
    }
}
