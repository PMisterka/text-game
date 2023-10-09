using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace CeltyckaPrzygoda
{
    class Enemies
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool isDead { get; set; }
        public void getsHit(int hitValue)
        {
            Health = Health - hitValue;

            if (Health > 0) Console.WriteLine(Name + " ma teraz " + Health + " punktów życia!");
            if (Health <= 0) Console.WriteLine(Name + " stracił wszystkie punkty życia!");


            if (Health <= 0)
            {
                Death();
            }
        }

        private void Death()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nPrzeciwnik pokonany!");

            isDead = true;
        }

        public Enemies(string name, int health)
        {
            Name = name;
            Health = health;
        }

    }
}
