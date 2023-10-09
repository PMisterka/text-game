using System;
using System.Threading;
using System.Media;


namespace CeltyckaPrzygoda
{
    class Program
    {

        public static string imie;
        static void Main(string[] args)
        {
            /*
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\muzyka.wav";
            player.Play();
            */
            Start.Game();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            Printing.Print("Samotne podróże mogą być niebezpieczne, szczególnie w świecie wypełnionym groźnymi potworami i wrogo nastawionymi plemionami. " +
                "\nPo wielu dniach podróży po zachodniej części kontynentu, nareszcie docierasz do małej osady na południu Galii. " +
                "\nJuż z daleka słychać wesołą muzykę i pełne życia rozmowy. Zbliżasz się więc do biesiadników.");
            
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Printing.Print("\n>Witaj nieznajomy, jak się nazywasz?");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n>");
            imie = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Printing.Print("\n>Witaj " + imie + ", jestem Evan, jeden z bardów tutejszego plemienia. Co cię tu sprowadza?");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n>Podróżuję w poszukiwaniu strzały Belenosa.");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Printing.Print("\n>Strzały Belenosa? Przecież to tylko legenda!");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n>Co o niej wiesz?");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Printing.Print("\n>Kiedy byłem dzieckiem, starsi wojownicy plemienia często rozmawiali o kołczanie ze strzałami Belenosa,\n ale żaden z nich nie odważył się wyruszyć " +
                "na jego poszukiwanie." +
                                "\n Dlaczego chcesz znaleźć tę strzałę?");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n>Ojciec opowiadał mi, że te strzały istnieją i mają wielką moc - potrafią uleczyć każdą chorobę.\n Podróżuję już od miesięcy i szukam osób, które" +
                " mogłyby mi pomóc dowiedzieć się czegoś więcej.");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Printing.Print("\n>Jeśli chcesz, możesz porozmawiać z naszym najstarszym druidem, Cathalem. Znajdziesz go w tamtej chacie.");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nNaciśnij dowolny klawisz, żeby odwiedzić chatę druida.");

            Console.ReadKey();
            Console.Clear();

            //CHATA DRUIDA

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Printing.Print(">Witaj " + imie + ", oczekiwałem twojego przyjścia. ");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n[1] Skąd wiedziałeś że przybędę?" +
                "\n[2] Więc zapewne wiesz o co chcę zapytać? ");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(">");
            string wybor = Console.ReadLine();



            while (wybor != "1" && wybor != "2")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Wybrano niepoprawną wartość.\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                wybor = Console.ReadLine();
            }

            if (wybor == "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Printing.Print("\n>Skąd? Jestem jasnowidzem. O co chcesz zapytać?");

                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n>Opowiedz mi o strzałach Belenosa.");
            };
            if (wybor == "2")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Printing.Print("\n>Chcesz poznać prawdę o strzałach Belenosa.");
            };

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Printing.Print("\n>Legendy mówią, że Belenos zostawił swoim wyznawcom kołczan z czterema strzałami." +
                "\n Po jednej dla każdego plemienia, które od zarania dziejów pielęgnowało jego pamięć i oddawało mu cześć. " +
                "\n Najwyżsi kapłani obawiali się, że boskie strzały są zbyt cenne i miejsca kultu mogą stać się narażone na ataki wrogich plemion." +
                "\n Zdecydowali, że kołczan i strzały zostaną rozdzielone i ukrtye w oddalonych od siebie miejscach." +
                "\n Jednym z tych najwyższych kapłanów był mój przodek, który zadbał o to, żeby historia boskiego spotkania i daru, jaki przekazał swoim wyznawcom Belenos, nie" +
                " została nigdy zapomniana. " +
                "\n Powtarzana z pokolenia na pokolenie opowieść przetrwała już 700 lat. I dziś ja opowiadam ją Tobie.");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n>A czy przodkowie opowiedzieli Ci, jak znaleźć te strzały?");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Printing.Print("\n>Według podań mojej rodziny, jedna ze strzał została ukryta w podziemnej świątyni, nieopodal naszej osady. " +
                "\n Jednak, żeby się do niej dostać, trzeba przejść przez las, z któego prawie nikt jeszcze nie powrócił" +
                "\n Sam chciałbym wybrać się w taką misję, ale mam już 132 lata i byłbym tylko ciężarem.");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n>Znasz jeszcze kogoś, kto mógłby chcieć zaryzykować swoje życie w poszukiwaniu tej strzały?");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Printing.Print("\n>Moja prawnuczka Erin jest bardzo dzielną czarodziejką i wiem, że chciałaby wrócić do korzeni naszego pochodzenia. " +
                "\n Może iść z Tobą, aby zgłębić tajemnice najwyższych kapłanów sprzed prawie wieku." +
                "\n Jeśli jednak chcesz, aby towarzyszył ci inny wojownik, możesz zabrać ze sobą Ardala. Jest świetnym łucznikiem i dobrze włada mieczem.");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n[1] Chcę iść sam" +
                "\n[2] Chcę zabrać ze sobą czarodziejkę Erin" +
                "\n[3] Chcę zabrać ze sobą wojownika Ardala");


            Console.ForegroundColor = ConsoleColor.Red;
            string wyborDrogi = Console.ReadLine();
            
            Thread.Sleep(1000);
            while (wyborDrogi != "1" && wyborDrogi != "2" && wyborDrogi != "3")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Wybrano niepoprawną wartość.\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(">");
                wyborDrogi = Console.ReadLine();
            }

            if (wyborDrogi == "1")
            {
                Path1.p1();
            };
            if (wyborDrogi == "2")
            {
                Path2.p2();
            };
            if (wyborDrogi == "3")
            {
                Path3.p3();
            };






        }
    }
}
