using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CeltyckaPrzygoda
{
    class Player
    {
        public int Health { get; set; }

        public Player()
        {

            Health = 100; //setting health

        }
        public bool isDodging { get; set; }

        public void getsHit(int hitValue)
        {
            if (isDodging == true)
            {
                isDodging = false;
            }
            else
            {
                Health = Health - hitValue;
                Console.WriteLine("\nZostałeś uderzony. Tracisz " + hitValue + " punktów życia!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Masz teraz " + Health + " punktów życia!");

            }

            if (Health <= 0)
            {
                Death();
            }
        }

        public void Heal(int healValue)
        {
            Health = Health + healValue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (Health > 100)
            {
                Health = 100;
            }
            Console.WriteLine("\nUleczyłeś się o " + healValue + " punktów." + "\nMasz teraz " + Health + " punktów życia!");
        }


        public bool isDead { get; set; }
        private void Death()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nNie żyjesz!");

            isDead = true;

            Thread.Sleep(3000);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n    - KONIEC GRY -    ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nNaciśnij dowolny klawisz, żeby zakończyć.");


        }
    }
}
