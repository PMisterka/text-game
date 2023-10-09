using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CeltyckaPrzygoda
{
    class Path1
    {
        public static void p1()
        {
            Console.Clear();

            Player player = new Player();

            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.White;
            Printing.Print("Idziesz w samotną pordóż.");

            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n- Tajemniczy las -");
            Thread.Sleep(2000);

            Printing.Print("\nWkraczasz do zaczarowanego lasu." +
                "\nNiesiesz ze sobą mapę, którą podarował Ci druid Cathal. Dzięki niej masz szansę odnaleźć podziemną świątynię." +
                "\nPo chwili, na swojej drodze napotykasz pierwszego przeciwnika.");

            //Przeciwnicy:
            Enemies firstEnemy = new Enemies("Olbrzymi Jadowity Pająk", 50);

            Enemies secondEnemy = new Enemies("Wilk", 30);

            Enemies thirdEnemy = new Enemies("Leśny Troll", 40);

            Enemies fourthEnemy = new Enemies("Rozwścieczony Niedźwiedź", 75); 

            Enemies fifthEnemy = new Enemies("Upiór", 30);

            Enemies sixthEnemy = new Enemies("Leśne Widmo", 50);

            EnemyFights1.Fights1(player, firstEnemy, rnd, 1, 5); //1 walka


            if (!player.isDead) //jeśli gracz żyje, kontynuujemy gre
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Printing.Print("\nTajemniczy las jest domem dla wielu stworzeń. Nie wszystkie z nich są zabójcze, ale spotkanie z każdym z nich będzie Cię kosztowało dużo energii." +
                    "\nPóki co, zdecyduj, jak spędzisz noc...");

                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n[1] Znajdź schronienie w grocie" +
                    "\n[2] Śpij pod gołym niebem");


                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                string wybor1 = Console.ReadLine();

                Thread.Sleep(1000);
                while (wybor1 != "1" && wybor1 != "2")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Wybrano niepoprawną wartość.\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">");
                    wybor1 = Console.ReadLine();
                }

                if (wybor1 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Printing.Print("\nPo prawie godzinie poszukiwań udaje Ci się wypatrzeć u podnóża góry niewielką jaskinię." +
                        "\nNagle głuchą ciszę przerywa wycie wilka. Słyszysz, że jest przy wejściu do Twojej groty...");

                    EnemyFights1.Fights1(player, secondEnemy, rnd, 10, 15);
                };
                if (wybor1 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Printing.Print("\nWyruszenie w tak niebezpieczną podróż samemu i sen bez dachu nad głową?" +
                        "\nNiektórzy powiedzą, że to odwaga, ale rację mają Ci, którzy nazwą to głupotą.");

                    EnemyFights1.Fights1(player, thirdEnemy, rnd, 30, 50);
                };

                if (!player.isDead)
                {
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nNaciśnij dowolny klawisz, żeby kontynuować");
                    Console.ReadKey();
                    Console.Clear();

                    int sleep = rnd.Next(10, 20);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Printing.Print("\nNowy dzień, nowe wyzwania. Odpoczynek sprawił, że odzyskujesz " + sleep + " punktów życia.");
                    player.Health = player.Health + sleep;
                    if (player.Health > 100) player.Health = 100;


                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Printing.Print("\nIdziesz dalej i widzisz, że ścieżka się rozwidla. Gdzie chcesz iść?");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n[1] Droga w lewo" +
                        "\n[2] Droga w prawo");


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">");
                    string wybor2 = Console.ReadLine();

                    Thread.Sleep(1000);
                    while (wybor2 != "1" && wybor2 != "2")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Wybrano niepoprawną wartość.\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        wybor2 = Console.ReadLine();
                    }

                    if (wybor2 == "1")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Printing.Print("\nWybrano drogę w lewo." +
                            "\nPrzedzierasz się przez gęsty las, nieopodal da się słyszeć dzwięki wartkich strumyków." +
                            "\nNagle pojawia się przed tobą nimfa leśna.");


                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Printing.Print("\n>Witaj śmiertelniku, co sprowadza cię w te strony?");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n>Poszukuję podziemnej świątyni, która znajduje się w tym lesie.");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Printing.Print("\n>My, leśne stworzenia nie lubimy nieproszonych gości, szczególnie ludzi." +
                            "\n Ty nie wyglądasz jednak na złą osobę. Jeśli odpowiesz na moje pytanie, usunę wszelkie niebezpieczeństwa z tej ścieżki.");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n>Jak brzmi pytanie?");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Printing.Print("\n>Nam, nimfom bardzo bliska jest bogini Brigit." +
                            "\n Czy wiesz jaka jest jej ulubiona broń?");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n[1] Sztylet" +
                            "\n[2] Włócznia" +
                            "\n[3] Proca");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        string zagadka = Console.ReadLine();

                        while (zagadka != "1" && zagadka != "2" && zagadka != "3")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Wybrano niepoprawną wartość.\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(">");
                            zagadka = Console.ReadLine();
                        }

                        if(zagadka == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Printing.Print("\n>Udało Ci się odpowiedzieć poprawnie. Dopilnuje, aby żadne dzikie zwierzęta nie przeszkadzały Ci na drodze do świątyni.");
                            Thread.Sleep(1000);
                        }

                        if (zagadka == "1" || zagadka == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Printing.Print("\n>Niestety jest to niepoprawna odpowiedź. Jesteś zdany na siebie.");
                            Thread.Sleep(1000);
                            EnemyFights1.Fights1(player, fourthEnemy, rnd, 1, 20);
                        }

                            
                    };
                    if (wybor2 == "2")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Printing.Print("\nWybrano drogę w prawo." +
                            "\nŚcieżka jest prosta, nie ma na niej wiele przeszkód, ale z każdą minutą niepokojące dzwięki są coraz głośniejsze.");

                        EnemyFights1.Fights1(player, fifthEnemy, rnd, 10, 20);

                        if (!player.isDead)
                        {
                            EnemyFights1.Fights1(player, sixthEnemy, rnd, 5, 10);
                        }

                    }

                    if (!player.isDead)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Printing.Print("\nSzybki rzut okiem na mapę mówi Ci, że opuszczona świątynia jest już blisko." +
                            "\nZnajdujesz wejście prowadzące pod ziemię. Wydobywają się z niej przerażające dźwięki." +
                            "\nPowolnym krokiem schodzisz coraz głębiej...");

                        int potion = rnd.Next(0, 10);
                        if (potion < 4)
                        {
                            player.Health = player.Health + 10;
                            if (player.Health > 100) player.Health = 100;
                            Printing.Print("\nBrak pośpiechu opłacił się, chwila odpoczynku regeneruje 10 punktów życia");
                        }

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\nNaciśnij dowolny klawisz, żeby kontynuować");
                        Console.ReadKey();
                        Console.Clear();

                        
                        
                        // BOSS ROOM


                        //Przeciwnicy przed bossem:
                        Enemies preBoss1 = new Enemies("Mroczny Elf", 30);

                        Enemies preBoss2 = new Enemies("Zły Duch", 45);

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Printing.Print("\nWiesz, że strzała znajduje się w centrum świątyni. Aby się tam dostać, musisz najpierw stawić czoła przeciwnikom, którzy strzegą jej wejścia.");

                        EnemyFights1.Fights1(player, preBoss1, rnd, 1, 20);

                        if (!player.isDead)
                        {
                            EnemyFights1.Fights1(player, preBoss2, rnd, 1, 20);

                            if (!player.isDead)
                            {

                                Thread.Sleep(1000);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("\nNaciśnij dowolny klawisz, żeby kontynuować");
                                Console.ReadKey();
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Printing.Print("\nUdało ci się pokonać wszystkich przeciwników - upragniona strzała " +
                                    "Belenosa jest już zasięgu wzroku. Podchodzisz bliżej i nagle, dookoła " +
                                    "Ciebie wybuchają płomienie." +
                                    "\nOgnisty krąg zaczyna płonąć coraz jaśniej, a naprzeciw Ciebie pojawia się Duch Druida...");

                                
                                Enemies boss = new Enemies("Zły Druid", 80);

                                EnemyFights1.BossFight1(player, boss, rnd, 10, 30);

                                if (!player.isDead)
                                {

                                    Thread.Sleep(2000);

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Printing.Print("\nGratulacje, pokonałeś ostatniego przeciwnika!");

                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Printing.Print("\nDzięki Twoim heroicznym czynom, zdobywasz strzałę Belenosa." +
                                        "\nDzięki niej, po powrocie do wioski uzdrawiasz wszystkich jej mieszkańców, " +
                                        "\na miejscowi bardowie będą wspominać Twoje imię w pieśniach.");

                                    Thread.Sleep(1000);
                                    Console.WriteLine("\nNaciśnij dowolny klawisz, żeby kontynuować");
                                    Console.ReadKey();

                                    TheEnd.End();
                        

                                }
                                else
                                {
                                    Console.ReadKey();
                                }

                            }
                            else
                            {
                                Console.ReadKey();
                            }

                        }
                        else
                        {
                            Console.ReadKey();
                        }


                    }

                    else
                    {
                        Console.ReadKey();
                    }






                }

                else
                {
                    Console.ReadKey();
                }

            }

            else
            {
                Console.ReadKey();
            }

        }

    }
}
