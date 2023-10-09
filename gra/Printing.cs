using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CeltyckaPrzygoda
{
    class Printing
    {
        public static void Print(string tekst, int speed = 35)
        {
            foreach (char c in tekst)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
            
        }
    }
}
