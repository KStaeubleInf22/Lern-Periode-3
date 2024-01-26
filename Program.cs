using System.Globalization;

namespace LP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool HAAA = true;
            while (HAAA)
            {
                HAAA = false;
                bool hasBug = true;
                bool hasBug2 = true;
                bool hasBug3 = true;
                bool hasBro = true;
                bool HazBog = true;
                int Zahl = 0;
                int Zahl2 = 0;
                while (hasBug)
                {
                    Console.WriteLine("Bitte geben sie eine ganze Zahl ein über 0");
                    try
                    {
                        Zahl = Convert.ToInt32(Console.ReadLine());
                        if (Zahl <= 0)
                        {
                            Console.WriteLine("Error, die Eingabe ist unter 0.");
                            hasBug = true;
                        }
                        else
                        {
                            Console.WriteLine(Zahl + " ist deine Zahl");
                            hasBug = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error, die Eingabe ist keine Zahl");
                        hasBug = true;
                    }
                }
                Thread.Sleep(1000);
                while (hasBug2)
                {
                    Console.WriteLine("Bitte geben sie eine weitere ganze Zahl ein die über 0 ist");
                    try
                    {
                        Zahl2 = Convert.ToInt32(Console.ReadLine());
                        if (Zahl2 <= 0)
                        {
                            Console.WriteLine("Error, die Eingabe ist unter 0.");
                            hasBug2 = true;
                        }
                        else
                        {
                            Console.WriteLine(Zahl2 + " ist deine zweite Zahl");
                            hasBug2 = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error, die Eingabe ist keine Zahl");
                        hasBug2 = true;
                    }
                }
                Thread.Sleep(1000);
                while (hasBug3)
                {
                    Console.WriteLine("Würdest du gerne eine Rechnung durchführen?");
                    Console.WriteLine("Bitte geben sie Nein/Ja genau ein.");
                    try
                    {
                        string Antwort = (Console.ReadLine());
                        if (Antwort == "Nein")
                        {
                            Console.WriteLine("OK.");
                            hasBug3 = false;
                            Environment.Exit(0);
                        }
                        else if (Antwort == "Ja")
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Wie wollen sie es verrechnen?");
                            hasBug3 = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error, nicht korrekt geschrieben");
                        hasBug3 = true;
                    }
                }
                while (hasBro)
                {
                    Console.WriteLine("+/-/:/*/xy/Z1/Z2");
                    Console.WriteLine("Z1 und Z2 kann man benutzen um die Zahlen zu ändern.");
                    try
                    {
                        string Mathe = (Console.ReadLine());
                        if (Mathe == "+")
                        {
                            Console.WriteLine(Zahl + Zahl2);
                            hasBro = false;

                        }
                        else if (Mathe == "-")
                        {
                            Console.WriteLine(Zahl - Zahl2);
                            hasBro = false;
                        }
                        else if (Mathe == ":")
                        {
                            double Teilung = Zahl / Zahl2;
                            Console.WriteLine(Teilung);
                            hasBro = false;
                        }
                        else if (Mathe == "*")
                        {

                            Console.WriteLine(Zahl * Zahl2);
                            hasBro = false;
                        }
                        else if (Mathe == "Walter White")
                        {

                            Console.WriteLine("Who are you talking to right now? Who is it that you think you see?");
                            Thread.Sleep(2400);
                            Console.WriteLine("Do you know how much I make a year?");
                            Thread.Sleep(1800);
                            Console.WriteLine("I mean, even if I tell you, you wouldn’t believe it.");
                            Thread.Sleep(2400);
                            Console.WriteLine("Do you know what happens if I suddenly decide to stop going into work?");
                            Thread.Sleep(2400);
                            Console.WriteLine("A business big enough it could be listed on the NASDAQ goes belly-up. Gone. It ceases to exist without me.");
                            Thread.Sleep(3000);
                            Console.WriteLine("No, you clearly don’t know who you’re talking to so let me clue you in.");
                            Thread.Sleep(2400);
                            Console.WriteLine("I am not in danger, Skylar. I AM the danger.");
                            Thread.Sleep(2400);
                            Console.WriteLine("A guy opens his front door and gets shot, and you think that of me? No.");
                            Thread.Sleep(3000);
                            Console.WriteLine("I am the one who KNOCKS.");
                            Thread.Sleep(1000);
                            hasBro = true;
                        }
                        else if (Mathe == "xy")
                        {
                            for (int i = 0; i < Zahl2 + 1; i++)
                            {
                                double ans = Math.Pow(Zahl, i);
                                Console.WriteLine(ans);
                                hasBro = false;
                            }
                        }
                        else if (Mathe == "Z1")
                        {
                            try
                            {

                                Console.WriteLine("Bitte eine neue Zahl eingeben");
                                Zahl = Convert.ToInt32(Console.ReadLine());
                                if (Zahl <= 0)
                                {
                                    Console.WriteLine("Error, die Eingabe ist unter 0.");
                                    hasBro = true;
                                }
                                else
                                {
                                    Console.WriteLine(Zahl + " ist deine Zahl");
                                    hasBro = true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Error, die Eingabe ist keine Zahl");
                                hasBro = true;
                            }
                        }
                        else if (Mathe == "Z2")
                        {
                            try
                            {

                                Console.WriteLine("Bitte eine neue Zahl eingeben");
                                Zahl2 = Convert.ToInt32(Console.ReadLine());
                                if (Zahl2 <= 0)
                                {
                                    Console.WriteLine("Error, die Eingabe ist unter 0.");
                                    hasBro = true;
                                }
                                else
                                {
                                    Console.WriteLine(Zahl2 + " ist deine Zahl");
                                    hasBro = true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Error, die Eingabe ist keine Zahl");
                                hasBro = true;
                            }
                        }
                    }
                    catch
                    {

                        Console.WriteLine("Error, Die eingabe ist Falsch");
                        hasBro = false;
                    }
                }
                while (HazBog)

                {
                    Console.WriteLine("Würdest du gerne neu anfangen? Ja/Nein");
                    try
                    {
                        string Antwort = (Console.ReadLine());
                        if (Antwort == "Nein")
                        {
                            Console.WriteLine("OK.");
                            HazBog = false;
                            Environment.Exit(0);
                        }
                        else if (Antwort == "Ja")
                        {
                            HAAA = true;
                            HazBog = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error, nicht korrekt geschrieben");
                        HazBog = true;
                    }
                }

            }
        }
    }
}