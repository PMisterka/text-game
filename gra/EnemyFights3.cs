using System;
using System.Collections.Generic;
using System.Text;

namespace CeltyckaPrzygoda
{
    class EnemyFights3
    {
        public static void Fights3(Player player, Enemies enemy, Random rnd, int minAttack, int maxAttack)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Printing.Print("Na swojej drodze napotykacie przeciwnika. Jest to " + enemy.Name);

            while (!enemy.isDead && !player.isDead)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n[1] Atak " +
                    "\n[2] Podwójny atak " +
                    "\n[3] Unik " +
                    "\n[4] Leczenie");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nWykonujesz atak mieczem");
                        enemy.getsHit(rnd.Next(10, 20));

                        if (enemy.isDead) break;

                        Console.WriteLine("\nArdal atakuje przeciwnika");
                        enemy.getsHit(rnd.Next(10, 20));


                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nWykonujesz dwa cięcia mieczem");

                        for (int i = 0; i < 2; i++)
                        {
                            enemy.getsHit(rnd.Next(5, 15));
                            if (enemy.isDead) break;
                        }

                        if (enemy.isDead) break;

                        Console.WriteLine("\nArdal atakuje przeciwnika");
                        enemy.getsHit(rnd.Next(10, 15));
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        int dodge = rnd.Next(0, 10);
                        if (dodge != 5)
                        {
                            player.isDodging = true;
                            int dodge2 = rnd.Next(0, 10);
                            if (dodge2 < 5)
                            {
                                Console.WriteLine("\nTy i Ardal unikneliście ataku. Regenerujesz 3 punkty życia.");
                                player.Heal(3);
                            }
                            else
                            {
                                Console.WriteLine("\nTy i Ardal unikneliście ataku.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("\nNie udało wam się uniknąć ataku.");

                        }
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nLeczenie ran");

                        player.Heal(rnd.Next(10, 30));


                        break;

                    default:
                        player.isDodging = true;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Wybrano niepoprawną wartość.\n");
                        break;
                }

                if (!enemy.isDead)
                {
                    player.getsHit(rnd.Next(minAttack, maxAttack));
                }

            }
        }

        public static void BossFight3(Player player, Enemies boss, Random rnd, int minAttack, int maxAttack)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Printing.Print("Na swojej drodze napotykacie przeciwnika. Jest to " + boss.Name);

            while (!boss.isDead && !player.isDead)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n[1] Atak " +
                    "\n[2] Podwójny atak " +
                    "\n[3] Unik " +
                    "\n[4] Leczenie");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nWykonujesz atak mieczem");
                        boss.getsHit(rnd.Next(10, 20));

                        if (boss.isDead) break;

                        Console.WriteLine("\nArdal atakuje przeciwnika");
                        boss.getsHit(rnd.Next(10, 20));

                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nWykonujesz dwa cięcia mieczem");
                        for (int i = 0; i < 2; i++)
                        {
                            boss.getsHit(rnd.Next(5, 15));
                            if (boss.isDead) break;
                        }

                        if (boss.isDead) break;

                        Console.WriteLine("\nArdal atakuje przeciwnika");
                        boss.getsHit(rnd.Next(10, 15));
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        int dodge = rnd.Next(0, 10);
                        if (dodge != 5)
                        {
                            player.isDodging = true;
                            int dodge2 = rnd.Next(0, 10);
                            if (dodge2 < 5)
                            {
                                Console.WriteLine("\nTy i Ardal unikneliście ataku. Regenerujesz 5 punktów życia.");
                                player.Heal(5);
                            }
                            else
                            {
                                Console.WriteLine("\nTy i Ardal unikneliście ataku.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("\nNie udało wam się uniknąć ataku.");

                        }
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nLeczenie ran");

                        player.Heal(rnd.Next(20, 30));

                        break;

                    default:
                        player.isDodging = true;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Wybrano niepoprawną wartość.\n");
                        break;
                }

                if (!boss.isDead)
                {
                    player.getsHit(rnd.Next(minAttack, maxAttack));
                }



            }
        }
    }
}
