using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CeltyckaPrzygoda
{
    class Path3
    {
        public static void p3()
        {
            Console.Clear();

            Player player = new Player();

            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.White;
            Printing.Print("Wybrałeś podróż z wojownikiem Ardalem"); // ardal mowi o asteriksie i obelixie

            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n- Tajemniczy las -");

            Thread.Sleep(2000);

            Printing.Print("\nWkraczasz do zaczarowanego lasu. Zaraz za Tobą podąża wojownik Ardal." +
                "\nNiesiesz ze sobą mapę, którą podarował Ci druid Cathal. Dzięki niej macie szansę odnaleźć " +
                "podziemną świątynię." +
                "\nPo chwili, na swojej drodze napotykacie pierwszego przeciwnika.");



            Enemies firstEnemy = new Enemies("Olbrzymi Jadowity Pająk", 65);

            Enemies secondEnemy = new Enemies("Wilk", 45);

            Enemies thirdEnemy = new Enemies("Leśny Troll", 55);

            Enemies fourthEnemy = new Enemies("Rozwścieczony Niedźwiedź", 70); 

            Enemies fifthEnemy = new Enemies("Upiór", 45);

            Enemies sixthEnemy = new Enemies("Leśne Widmo", 65);

            EnemyFights3.Fights3(player, firstEnemy, rnd, 1, 5);


            if (!player.isDead)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Printing.Print("\nTajemniczy las jest domem dla wielu stworzeń. Nie wszystkie z nich są zabójcze, ale spotkanie " +
                    "z każdym z nich będzie Was kosztowało dużo energii." +
                    "\nNa szczęscie Ardal ma świetną orientację w terenie oraz był już w tych okolicach. " +
                    "Możesz słuchać jego rad, albo podejmować własne decyzje." +
                    "\nPóki co, zdecydujcie jak spędzicie noc...");

                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n[1] Znajdź schronienie w grocie" +
                    "\n[2] Śpij pod gołym niebem" +
                    "\n[3] Zapytaj o zdanie Ardala");


                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                string wybor1 = Console.ReadLine();

                Thread.Sleep(1000);
                while (wybor1 != "1" && wybor1 != "2" && wybor1 != "3")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Wybrano niepoprawną wartość.\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">");
                    wybor1 = Console.ReadLine();
                }

                if (wybor1 == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Printing.Print("\n>Myślę, że dużo bezpieczniej byłoby znaleźć scronienie w jaskini.\n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n[1] Znajdź schronienie w grocie" +
                        "\n[2] Śpij pod gołym niebem");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">");
                    wybor1 = Console.ReadLine();
                }

                while (wybor1 != "1" && wybor1 != "2" )
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
                    Console.WriteLine("\nPo prawie godzinie poszukiwań udaje Ci się wypatrzeć u podnóża góry niewielką jaskinię." +
                        "\nNagle głuchą ciszę przerywa wycie wilka. Słyszycie, że jest przy wejściu do Waszej groty...");

                    EnemyFights3.Fights3(player, secondEnemy, rnd, 10, 15);
                };
                if (wybor1 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Printing.Print("\nWyruszenie w tak niebezpieczną podróż i sen bez dachu nad głową? " +
                        "\nNiektórzy powiedzą, że to odwaga, ale racje mają Ci, którzy nazwą to głupotą");

                    EnemyFights3.Fights3(player, thirdEnemy, rnd, 30, 50);
                };



                if (!player.isDead)
                {
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nNaciśnij dowolny klawisz, żeby kontynuować");
                    Console.ReadKey();
                    Console.Clear();

                    int sleep = rnd.Next(10, 30);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Printing.Print("\nNowy dzień, nowe wyzwania. Odpoczynek sprawił, że odzyskujesz " + sleep + " punktów życia");
                    player.Health = player.Health + sleep;
                    if (player.Health > 100) player.Health = 100;

                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Printing.Print("\n>Legenda o strzałach Belenosa jest bardzo stara, skąd o nich wiesz?");

                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n>Mój ojciec opowiadał mi o nich i o ich leczniczych właściwościach. ");

                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Printing.Print("\n>Dlaczego ich porzebujesz?");

                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n>Moją osadą, zawładnęła koszmarna zaraza, muszę ją uratować.");

                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Printing.Print("\n>Nie wiele osób ma tak wielkie serce, twoje plemię musi być dumne");


                    Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Printing.Print("\nIdziecie dalej i widzisz, że ścieżka się rozwidla. Gdzie chcesz iść?");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n[1] Droga w lewo" +
                        "\n[2] Droga w prawo" +
                    "\n[3] Zapytaj o zdanie Ardala");


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(">");
                    string wybor2 = Console.ReadLine();

                    Thread.Sleep(1000);
                    while (wybor2 != "1" && wybor2 != "2" && wybor2 != "3")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Wybrano niepoprawną wartość.\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        wybor2 = Console.ReadLine();
                    }
                    if (wybor2 == "3")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Printing.Print("\n>Intuicja mówi mi, że bezpieczniej będzie pójść w lewo, a Ty jak sądzisz?\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n[1] Droga w lewo" +
                        "\n[2] Droga w prawo");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        wybor2 = Console.ReadLine();
                    }

                    while (wybor2 != "1" && wybor2 != "2" )
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
                            "\nPrzedzieracie się przez gęsty las, niopodal da się słyszeć dzwięki wartkich strumyków." +
                            "\nNagle pojawia się przed wami nimfa leśna.");


                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Printing.Print("\n>Witajcie śmiertelnicy, co sprowadza was w te strony?");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n>Poszukuję podziemnej świątyni, która znajduje się w tym lesie.");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Printing.Print("\n>My, leśne stworzenia nie lubimy nieproszonych gości, szczególnie ludzi." +
                            "\n Wy nie wyglądacie jednak na złe osoby. Jeśli odpowiecie na moją pytanie, usunę wszelkie niebezpieczeństwa z tej ścieżki.");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n>Jak brzmi pytanie?");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Printing.Print("\n>Nam, nimfom bardzo bliska jest bogini Brigit." +
                            "\n Czy wiecie jaka jest jej ulubiona broń?");

                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n[1] Sztylet" +
                            "\n[2] Włócznia" +
                            "\n[3] Proca" +
                            "\n[4] Zapytaj o zdanie Ardala");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        string zagadka = Console.ReadLine();

                        while (zagadka != "1" && zagadka != "2" && zagadka != "3" && zagadka != "4")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Wybrano niepoprawną wartość.\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(">");
                            zagadka = Console.ReadLine();
                        }

                        if (zagadka == "4")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Printing.Print("\n>Brigit to bogini rzek, roślin i zwierząt, ale nie wiem jaka jest jej ulubiona broń.\n");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n[1] Sztylet" +
                            "\n[2] Włócznia" +
                            "\n[3] Proca");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(">");
                            zagadka = Console.ReadLine();
                        }

                        while (zagadka != "1" && zagadka != "2" && zagadka != "3" )
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Wybrano niepoprawną wartość.\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(">");
                            zagadka = Console.ReadLine();
                        }

                        if (zagadka == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Printing.Print("\n>Udało Wam się odpowiedzieć poprawnie. Dopilnuje, aby żadne dzikie zwierzęta nie przeszkadzały Wam na drodze do świątyni.");
                            Thread.Sleep(1000);
                        }

                        if (zagadka == "1" || zagadka == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Printing.Print("\n>Niestety jest to niepoprawna odpowiedź. Jesteście zdani na siebie.");
                            Thread.Sleep(1000);
                            EnemyFights1.Fights1(player, fourthEnemy, rnd, 10, 20);
                        }
                    };
                    if (wybor2 == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Printing.Print("\nWybrano drogę w prawo." +
                            "\nŚcieżka jest prosta, nie ma na niej wiele przeszkód, ale z każdą minutą niepokojące dzwięki są coraz głośniejsze.");

                        EnemyFights3.Fights3(player, fifthEnemy, rnd, 15, 20);

                        if (!player.isDead)
                        {
                            EnemyFights3.Fights3(player, sixthEnemy, rnd, 10, 20);
                        }
                    }

                    if (!player.isDead)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Printing.Print("\nSzybki rzut okiem na mapę mówi Ci, że opuszczona świątynia jest już blisko." +
                            "\nZnajdujecie wejście prowadzące pod ziemię. Wydobywają się z niej przerażające dźwięki." +
                            "\nPowolnym krokiem schodzicie coraz głębiej...");

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

                        Enemies preBoss1 = new Enemies("Mroczny Elf", 45);

                        Enemies preBoss2 = new Enemies("Zły Duch", 50);

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Printing.Print("\nWiesz, że strzała znajduje się w centrum świątyni. Aby się tam dostać, musisz " +
                            "najpierw stawić czoła przeciwnikom, którzy strzegą jej wejścia.");

                        EnemyFights3.Fights3(player, preBoss1, rnd, 1, 20);

                        if (!player.isDead)
                        {
                            EnemyFights3.Fights3(player, preBoss2, rnd, 1, 20);

                            if (!player.isDead)
                            {


                                Thread.Sleep(1000);
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("\nNaciśnij dowolny klawisz, żeby kontynuować");
                                Console.ReadKey();
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Printing.Print("\nUdało Wam się pokonać wszystkich przeciwników - upragniona strzała " +
                                    "Belenosa jest już zasięgu wzroku. Podchodzicie bliżej i nagle, dookoła " +
                                    "Was wybuchają płomienie." +
                                    "\nOgnisty krąg zaczyna płonąć coraz jaśniej, a naprzeciwko pojawia się Duch Druida...");

                                Enemies boss = new Enemies("Zły Druid", 90);

                                EnemyFights3.BossFight3(player, boss, rnd, 15, 30);

                                if (!player.isDead)
                                {

                                    Thread.Sleep(2000);

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Printing.Print("\nGratulacje, pokonaliście ostatniego przeciwnika!");

                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
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
