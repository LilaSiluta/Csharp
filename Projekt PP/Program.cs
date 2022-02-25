using System;
namespace Projekt_PP
{
    class Program
    {
        static void Main(string[] args)
        {
            string odp = "tak",książka, odp1="", odpp="", oddp="";
            int numer=0;
            int wyłącz = 0,skończ=0;
            Console.WriteLine("Witaj w biblotece Uniwersytetu Morskiego!");
            Console.WriteLine("Bardzo mnie cieszy, że tu zawitałeś/zawitałaś :)");
            Książka książka1 = new Książka("J.K.Rowling","Harry Potter, TOM 1",328,"Wypożyczona","Rafał Tracz", "13.01.2021");
            Książka książka2 = new Książka("Adam Mickiewicz","Pan Tadeusz",296,"Dostępna","","");
            Książka książka3 = new Książka("Bolesław Prus","Lalka",864,"Wypożyczona","Oliwia Milewska", "15.02.2021");
            Książka książka4 = new Książka("William Shakespeare","Romeo i Julia",152,"Wypożyczona","Oliwia Milewska", "28.01.2021");
            Książka książka5 = new Książka("Stefan Żeromski","Ludzie bezdomni",255,"Dostępna","","");
            Książka książka6 = new Książka("Zofia Nałkowska","Granica",216,"Dostępna","","");
            Książka książka7 = new Książka("Sofokles","Antygona",80,"Wypożyczona","Sonia Burek","13.03.2021");
            Książka książka8 = new Książka("Willian Shakespeare","Makbet",1236,"Dostępna","","");
            Książka książka9 = new Książka("Henryk Sienkiewicz","Krzyżacy",600,"Wypożyczona","Zuzanna Panasiuk", "12.01.2021");
            Książka książka10 = new Książka("Zbigiew Herbert","Poezje",800,"Dostępna","","");
            Książka książka11 = new Książka("George Orwell","Folwark Zwierzęcy",132,"Wypożyczona","Maciej Ekert","19.01.2021");
            Książka książka12 = new Książka("Zofia Nałkowska","Medaliony",64,"Dostępna","","");
            Książka książka13 = new Książka("Aleksander Fredro","Zemsta",120,"Wypożyczona","Mikołaj Piskorz","30.02.2021");
            Książka książka14 = new Książka("Juliusz Słowacki","Balladyna",170,"Wypożyczona","Bartosz Sawko", "01.03.2021");
            Książka książka15 = new Książka("Witold Gombrowicz","Trans-Atlantyk",150,"Dostępna","","");
            Książka książka16 = new Książka("Sławomir Mrożek","Tango",208,"Dostępna","","");
            Książka książka17 = new Książka("Henryk Sienkiewicz","Potop",936,"Dostępna","","");
            Książka książka18 = new Książka("Stanisław Wyspiański","Wesele",210,"Wypożyczona","Julia Kamińska","08.03.2021");
            Książka książka19 = new Książka("Aleksander Kamiński","Kamienie na szaniec",256,"Dostępna","","");
            Książka książka20 = new Książka("Agatha Christie","Morderstwo w Orient Expressie",264,"Wypożyczona","Marcin Żwirełło", "27.02.2021");
            Książka książka21 = new Książka("Antoine de Saint-Exupery","Mały Książe",80,"Wypożyczona","Lidia Siluta", "30.01.2021"); //To jedna z moich ulubionych książek, nie mogło jej tu zabraknąć :P
            Książka książka22 = new Książka("William Shakespeare","Hamlet",192,"Wypożyczona","Sonia Burek","15.02.2021");
            Książka książka23 = new Książka("Henryk Sienkiewicz","Ogniem i mieczem",844,"Dostępna","","");
            Książka książka24 = new Książka("Stefan Żeromski", "Syzyfowe prace",192, "Dostępna","","");
            Książka książka25 = new Książka("Witold Gombrowicz", "Ferdydurke", 296, "Wypożyczona","Lidia Siluta","30.03.2021");
            Console.WriteLine("--> Czy chcesz zobaczyć spis wszystkich książek posiadanych przez naszą wspaniałą Bibliotekę? :)");
            odpp = Console.ReadLine();
            if (odpp.ToLower()=="tak")
            {
                Console.WriteLine("**************SPIS KSIĄŻEK***********");
                Console.WriteLine("- J.K.Rowling, 'Harry Potter, TOM 1'");
                Console.WriteLine("- Adam Mickiewicz, 'Pan Tadeusz'");
                Console.WriteLine("- Bolesław Prus, 'Lalka'");
                Console.WriteLine("- William Shakespeare, 'Romeo i Julia'");
                Console.WriteLine("- Stefan Żeromski, 'Ludzie bezdomni'");
                Console.WriteLine("- Zofia Nałkowska, 'Granica'");
                Console.WriteLine("- Sofokles, 'Antygona'");
                Console.WriteLine("- Willian Shakespeare, 'Makbet'");
                Console.WriteLine("- Henryk Sienkiewicz, 'Krzyżacy'");
                Console.WriteLine("- Zbigiew Herbert, 'Poezje'");
                Console.WriteLine("- George Orwell, 'Folwark Zwierzęcy'");
                Console.WriteLine("- Zofia Nałkowska, 'Medaliony'");
                Console.WriteLine("- Aleksander Fredro, 'Zemsta'");
                Console.WriteLine("- Juliusz Słowacki, 'Balladyna'");
                Console.WriteLine("- Witold Gombrowicz, 'Trans-Atlantyk'");
                Console.WriteLine("- Sławomir Mrożek, 'Tango'");
                Console.WriteLine("- Henryk Sienkiewicz, 'Potop'");
                Console.WriteLine("- Stanisław Wyspiański, 'Wesele'");
                Console.WriteLine("- Aleksander Kamiński, 'Kamienie na szaniec'");
                Console.WriteLine("- Agatha Christie, 'Morderstwo w Orient Expressie'");
                Console.WriteLine("- Antoine de Saint-Exupery, 'Mały Książe'");
                Console.WriteLine("- William Shakespeare, 'Hamlet'");
                Console.WriteLine("- Henryk Sienkiewicz, 'Ogniem i mieczem'");
                Console.WriteLine("- Stefan Żeromski, 'Syzyfowe prace'");
                Console.WriteLine("- Witold Gombrowicz, 'Ferdydurke'");
                Console.WriteLine("*************************************");
            };
            Czytelnik czytelnik1 = new Czytelnik("Lidia Siluta",47651,"Mały Książe","Ferdydurke");
            Czytelnik czytelnik2 = new Czytelnik("Oliwia Milewska",47542,"Lalka","Romeo i Julia");
            Czytelnik czytelnik3 = new Czytelnik("Zuzanna Panasiuk",47432,"Krzyżacy","brak");
            Czytelnik czytelnik4 = new Czytelnik("Rafał Tracz",47778,"Harry Potter, TOM 1","brak");
            Czytelnik czytelnik5 = new Czytelnik("Mikołaj Piskorz",47562,"Zemsta","brak");
            Czytelnik czytelnik6 = new Czytelnik("Bartosz Sawko",47812,"Balladyna","brak");
            Czytelnik czytelnik7 = new Czytelnik("Marcin Żwirełło",47321,"Morderstwo w Orient Expressie","brak");
            Czytelnik czytelnik8 = new Czytelnik("Julia Kamińska",47289,"Wesele","brak");
            Czytelnik czytelnik9 = new Czytelnik("Maciej Ekert",47052,"Folwark Zwierzęcy","brak");
            Czytelnik czytelnik10 = new Czytelnik("Sonia Burek",47113,"Antygona","Hamlet");
            Czytelnik czytelnik11 = new Czytelnik("Marcin Kubach", 47338, "brak", "brak");
            while (numer != czytelnik1.numerAlbumu && numer != czytelnik2.numerAlbumu && numer != czytelnik3.numerAlbumu && numer != czytelnik4.numerAlbumu 
                && numer != czytelnik5.numerAlbumu && numer != czytelnik6.numerAlbumu && numer != czytelnik7.numerAlbumu && numer != czytelnik8.numerAlbumu 
                && numer != czytelnik9.numerAlbumu && numer != czytelnik10.numerAlbumu && numer != czytelnik11.numerAlbumu)
            {
                Console.WriteLine("--> Proszę podać numer swojego albumu:");
                numer = Convert.ToInt32(Console.ReadLine());
            }
            while (odp=="tak")
            {
                Console.WriteLine("--> Czy chciałbyś/chciałabyś wypożyczyć jakąś książkę?");
                odp = Console.ReadLine();
                if (odp=="nie")
                {
                    break;
                }
                Czymożewypożyczyć(czytelnik1,numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik2, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik3, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik4, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik5, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik6, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik7, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik8, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik9, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik10, numer, ref wyłącz);
                Czymożewypożyczyć(czytelnik11, numer, ref wyłącz);
                if (wyłącz==1)
                {
                    break;
                };
                Console.WriteLine("--> Jaką książkę chciałbyś/chciałabyś wypożyczyć?");
                książka = Console.ReadLine();
                Wypożyczenie(książka1, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                    czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka2, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka3, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka4, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka5, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka6, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka7, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka8, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka9, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka10, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka11, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka12, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka13, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka14, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka15, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka16, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka17, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka18, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka19, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka20, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka21, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka22, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka23, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka24, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                Wypożyczenie(książka25, książka, czytelnik1, czytelnik2, czytelnik3, czytelnik4, czytelnik5, czytelnik6, czytelnik7,
                   czytelnik8, czytelnik9, czytelnik10, czytelnik11, numer, ref skończ);
                if (skończ == 1)
                {
                    break;
                };
            };
            Console.WriteLine("--> Czy chcesz złożyć rezerwację na wybraną przez Ciebie książkę?");
            oddp = Console.ReadLine();
            if (oddp=="tak")
            {
                Console.WriteLine("Niestety na czas pandemii nie przyjmujemy żadnych rezerwacji.");
                Console.WriteLine("Przepraszamy :(");
            };
            Console.WriteLine("--> Czy chcesz sprawdzić stan swojego konta bibliotecznego?");
            odp1 = Console.ReadLine();
            if (odp1 == "tak")
            {
                OgólnyZwrot(czytelnik1, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik2, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik3, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik4, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik5, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik6, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik7, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik8, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik9, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik10, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
                OgólnyZwrot(czytelnik11, numer, książka1, książka2, książka3, książka4, książka5, książka6, książka7, książka8, książka9, książka10, książka11,
                    książka12, książka13, książka14, książka15, książka16, książka17, książka18, książka19, książka20, książka21, książka22, książka23,
                    książka24, książka25);
            };
            Console.WriteLine(" ");
            Console.WriteLine("Bardzo dziękujemy za skorzystanie ze strony naszej Biblioteki!");
            Console.WriteLine("Liczymy na to, że wkrótce znów się u nas pojawisz :)");
            Console.ReadKey(true);
        }
        static public void Czymożewypożyczyć(Czytelnik czytelnik, int numer, ref int wyłącz)
        {
            if (czytelnik.numerAlbumu == numer)
            {
                if (czytelnik.stan1 != "brak" && czytelnik.stan2!="brak")
                {
                    Console.WriteLine("--> Niestety masz już wypożyczone 2 książki na swoje konto, więc nie możesz wypożyczyć więcej :(");
                    wyłącz = 1;
                }
            };
        }
        static public void Wypożyczenie(Książka książka1,string książka, Czytelnik czytelnik1, Czytelnik czytelnik2, Czytelnik czytelnik3,
            Czytelnik czytelnik4, Czytelnik czytelnik5, Czytelnik czytelnik6, Czytelnik czytelnik7, Czytelnik czytelnik8, Czytelnik czytelnik9,
            Czytelnik czytelnik10, Czytelnik czytelnik11, int numer, ref int skończ)
        {
            string odp2, odp3;
            DateTime dt1 = DateTime.Now;
            if (książka1.tytuł == książka)
            {
                if (książka1.stan == "Wypożyczona")
                {
                    Console.WriteLine("Ksiązka jest niedostępna.");
                    Console.WriteLine("Czy chcesz wiedzieć kto posiada książkę?");
                    odp3 = Console.ReadLine();
                    if (odp3 == "tak")
                    {
                        Console.WriteLine("Książkę posiada " + książka1.imięPosiadacza + ".Książka jest niedostępna do dnia: " + książka1.termin);
                    };
                }
                else
                {
                    Console.WriteLine("Ksiązka jest dostępna.");
                    Console.WriteLine("Czy chcesz ją wypożyczyć?");
                    odp2 = Console.ReadLine();
                    if (odp2 == "tak")
                    {
                        książka1.stan = "Wypożyczona";
                        książka1.termin = Convert.ToString(dt1.AddMonths(1));
                        Console.WriteLine("Książka została przez Ciebie wypożyczona do dnia: " + książka1.termin);
                        if (numer == czytelnik1.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik1.imię;
                            if(czytelnik1.stan1=="brak")
                            {
                                czytelnik1.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik1.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik2.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik2.imię;
                            if (czytelnik2.stan1 == "brak")
                            {
                                czytelnik2.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik2.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik3.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik3.imię;
                            if (czytelnik3.stan1 == "brak")
                            {
                                czytelnik3.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik3.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik4.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik4.imię;
                            if (czytelnik4.stan1 == "brak")
                            {
                                czytelnik4.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik4.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik5.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik5.imię;
                            if (czytelnik5.stan1 == "brak")
                            {
                                czytelnik5.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik5.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik6.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik6.imię;
                            if (czytelnik6.stan1 == "brak")
                            {
                                czytelnik6.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik6.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik7.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik7.imię;
                            if (czytelnik7.stan1 == "brak")
                            {
                                czytelnik7.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik7.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik8.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik8.imię;
                            if (czytelnik8.stan1 == "brak")
                            {
                                czytelnik8.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik8.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik9.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik9.imię;
                            if (czytelnik9.stan1 == "brak")
                            {
                                czytelnik9.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik9.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik10.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik10.imię;
                            if (czytelnik10.stan1 == "brak")
                            {
                                czytelnik10.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik10.stan2 = książka1.tytuł;
                            }
                        };
                        if (numer == czytelnik11.numerAlbumu)
                        {
                            książka1.imięPosiadacza = czytelnik11.imię;
                            if (czytelnik11.stan1 == "brak")
                            {
                                czytelnik11.stan1 = książka1.tytuł;
                            }
                            else
                            {
                                czytelnik11.stan2 = książka1.tytuł;
                            }
                        };
                    }
                    else
                    {
                        skończ = 1;
                    };
                }
            }
        }
        public static void ZwrotA(Czytelnik czytelnik1,Książka książka1)
        {
            if (czytelnik1.stan1 == książka1.tytuł)
            {
                książka1.stan = "Dostępna";
                Console.WriteLine("'"+książka1.tytuł+"'" + " została przez Ciebie zwrócona i jest dostępna na stronie Biblioteki!");
                książka1.imięPosiadacza = "";
                książka1.termin = "";
            };
        }
        public static void ZwrotB(Czytelnik czytelnik1,Książka książka1)
        {
            if (czytelnik1.stan2 == książka1.tytuł)
            {
                książka1.stan = "Dostępna";
                Console.WriteLine("'" + książka1.tytuł + "'" + " została przez Ciebie zwrócona i jest dostępna na stronie Biblioteki!");
                książka1.imięPosiadacza = "";
                książka1.termin = "";
            };
        }
        public static void OgólnyZwrot(Czytelnik czytelnik1,int numer, Książka książka1, Książka książka2, Książka książka3, Książka książka4, Książka książka5, 
            Książka książka6, Książka książka7, Książka książka8, Książka książka9, Książka książka10, Książka książka11, Książka książka12, Książka książka13, 
            Książka książka14, Książka książka15, Książka książka16, Książka książka17, Książka książka18, Książka książka19, Książka książka20, Książka książka21, 
            Książka książka22, Książka książka23, Książka książka24, Książka książka25)
        {
            string oddpp,oodp;
            if (numer == czytelnik1.numerAlbumu)
            {
                Console.WriteLine("--> Status Twojego konta:");
                if (czytelnik1.stan1 != "brak")
                {
                    Console.WriteLine("A) " + czytelnik1.stan1);
                };
                if (czytelnik1.stan2 != "brak")
                {
                    Console.WriteLine("B) " + czytelnik1.stan2);
                };
                Console.WriteLine("--> Czy chcesz zwrócić jakąś książkę?");
                oddpp = Console.ReadLine();
                if (oddpp == "tak")
                {
                    Console.WriteLine("-->Którą pozycję chcesz zwrócić: A czy B ?");
                    oodp = Console.ReadLine();
                    if (oodp == "A")
                    {
                        ZwrotA(czytelnik1, książka1);
                        ZwrotA(czytelnik1, książka2);
                        ZwrotA(czytelnik1, książka3);
                        ZwrotA(czytelnik1, książka4);
                        ZwrotA(czytelnik1, książka5);
                        ZwrotA(czytelnik1, książka6);
                        ZwrotA(czytelnik1, książka7);
                        ZwrotA(czytelnik1, książka8);
                        ZwrotA(czytelnik1, książka9);
                        ZwrotA(czytelnik1, książka10);
                        ZwrotA(czytelnik1, książka11);
                        ZwrotA(czytelnik1, książka12);
                        ZwrotA(czytelnik1, książka13);
                        ZwrotA(czytelnik1, książka14);
                        ZwrotA(czytelnik1, książka15);
                        ZwrotA(czytelnik1, książka16);
                        ZwrotA(czytelnik1, książka17);
                        ZwrotA(czytelnik1, książka18);
                        ZwrotA(czytelnik1, książka19);
                        ZwrotA(czytelnik1, książka20);
                        ZwrotA(czytelnik1, książka21);
                        ZwrotA(czytelnik1, książka22);
                        ZwrotA(czytelnik1, książka23);
                        ZwrotA(czytelnik1, książka24);
                        ZwrotA(czytelnik1, książka25);
                        czytelnik1.stan1 = "";
                    }
                    if (oodp == "B")
                    {
                        ZwrotB(czytelnik1, książka1);
                        ZwrotB(czytelnik1, książka2);
                        ZwrotB(czytelnik1, książka3);
                        ZwrotB(czytelnik1, książka4);
                        ZwrotB(czytelnik1, książka5);
                        ZwrotB(czytelnik1, książka6);
                        ZwrotB(czytelnik1, książka7);
                        ZwrotB(czytelnik1, książka8);
                        ZwrotB(czytelnik1, książka9);
                        ZwrotB(czytelnik1, książka10);
                        ZwrotB(czytelnik1, książka11);
                        ZwrotB(czytelnik1, książka12);
                        ZwrotB(czytelnik1, książka13);
                        ZwrotB(czytelnik1, książka14);
                        ZwrotB(czytelnik1, książka15);
                        ZwrotB(czytelnik1, książka16);
                        ZwrotB(czytelnik1, książka17);
                        ZwrotB(czytelnik1, książka18);
                        ZwrotB(czytelnik1, książka19);
                        ZwrotB(czytelnik1, książka20);
                        ZwrotB(czytelnik1, książka21);
                        ZwrotB(czytelnik1, książka22);
                        ZwrotB(czytelnik1, książka23);
                        ZwrotB(czytelnik1, książka24);
                        ZwrotB(czytelnik1, książka25);
                        czytelnik1.stan2 = "";
                    }
                }
            };
        }
    }
}