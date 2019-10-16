using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Menü");
        //    int auswahl;


        //    string wiederholung;

        //    do
        //    {
        //        Console.WriteLine("1: Aktion 1");
        //        Console.WriteLine("2: Aktion 2");
        //        Console.WriteLine("3: Aktion 3");

        //        Console.WriteLine("Aktion auswählen:");
        //        auswahl = Convert.ToInt32(Console.ReadLine());

        //        if (auswahl == 1)
        //        {
        //            Console.WriteLine("Hallo.");
        //        }
        //        else if (auswahl == 2)
        //        {
        //            Console.WriteLine("Guten Tag.");
        //        }
        //        else if (auswahl == 3)
        //        {
        //            Console.WriteLine("Guten Tag.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Ungültige Eingabe.");
        //        }

        //        Console.WriteLine("Neue Aktion wählen? (j/n):");
        //        wiederholung = Console.ReadLine();
        //    } while (wiederholung == "j");
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Umrechnen ");
            int auswahl;


            string wiederholung;

            do
            {
                Console.WriteLine("1: Dezimal zu Binär");
                Console.WriteLine("2: Binär zu Dezimal");
                Console.WriteLine("3: Dezimal zu Hexadezimal");
                Console.WriteLine("4: Hexadezimal zu Dezimal");

                Console.WriteLine("Aktion auswählen:");
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    // Umwandlung dezimal zu binär (spiegelverkehrte Ausgabe)
                    string eingabe, ausgabe = "";

                    Console.WriteLine("Dezimalzahl eingeben:");
                    eingabe = Console.ReadLine();
                    ausgabe = von10zu2(ausgabe);

                    //Ausgabe spiegeln

                    Console.WriteLine(eingabe + " in Binär: " + spiegeln(ausgabe));
                }
                else if (auswahl == 2)
                {
                    string eingabe;
                    double ausgabe;
                    Console.WriteLine("Binärzahl eingeben:");
                    eingabe = Console.ReadLine();
                    ausgabe = Von2zu10(eingabe);

                    Console.WriteLine(eingabe + " in Dezimal: " + ausgabe);
                }
                else if (auswahl == 3)
                {
                    // Umwandlung dezimal zu Hexadezimal (spiegelverkehrte Ausgabe)
                    string eingabe, ausgabe = "";

                    Console.WriteLine("Dezimalzahl eingeben:");
                    eingabe = Console.ReadLine();
                    ausgabe = von10zu16(eingabe);

                    //Ausgabe spiegeln

                    Console.WriteLine(eingabe + " in Hexadezimal: " + spiegeln(ausgabe));
                }
                else if (auswahl == 4)
                {
                    string eingabe;
                    double ausgabe;
                    Console.WriteLine("Hexadezimalzahl eingeben:");
                    eingabe = Console.ReadLine();
                    ausgabe = Von16zu10(eingabe);

                    Console.WriteLine(eingabe + " in Dezimal: " + ausgabe);
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }

                Console.WriteLine("Neue Aktion wählen? (j/n):");
                wiederholung = Console.ReadLine();
            } while (wiederholung == "j");
        }

        static string spiegeln(string input)
        {
            string ausgabe_R = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ausgabe_R += input[i];
            }
            return ausgabe_R;
        }

        static string von10zu2(string input)
        {
            string ausgabe = "";
            int dez, quotient = 1, rest;
            dez = Convert.ToInt32(input);

            while (quotient != 0)
            {
                quotient = dez / 2;
                rest = dez % 2;
                ausgabe += Convert.ToString(rest);
                dez = quotient;
            }
            return ausgabe;
        }

        static double Von2zu10(string input)
        {
            double dez = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int faktor = Convert.ToInt32(Convert.ToString(input[i]));
                double exponent = Convert.ToDouble(input.Length - 1 - i);
                dez += faktor * Math.Pow(2, exponent);
            }
            return dez;
        }
        static string von10zu16(string input)
        {
            string ausgabe = "";
            int dez, quotient = 1, rest;
            dez = Convert.ToInt32(input);

            while (quotient != 0)
            {
                quotient = dez / 16;
                rest = dez % 16;
                ausgabe += ZahlZuBuchstabe(rest);
                dez = quotient;
            }
            return ausgabe;
        }
        static string ZahlZuBuchstabe(int Zahl)
        {
            if (Zahl == 10) return "A";
            else if (Zahl == 11) return "B";
            else if (Zahl == 12) return "C";
            else if (Zahl == 13) return "D";
            else if (Zahl == 14) return "E";
            else if (Zahl == 15) return "F";
            else return Convert.ToString(Zahl);
        }
        static int BuchstabeZuZahl(String input)
        {
            if (input == "A") return 10;
            else if (input == "B") return 11;
            else if (input == "C") return 12;
            else if (input == "D") return 13;
            else if (input == "E") return 14;
            else if (input == "F") return 15;
            else return Convert.ToInt32(input);
        }
        static double Von16zu10(string input)
        {
            double dez = 0;
            for (int i = 0; i < input.Length; i++)
            {

                int faktor = (BuchstabeZuZahl(Convert.ToString(input[i])));
                double exponent = Convert.ToDouble(input.Length - 1 - i);
                dez += faktor * Math.Pow(16, exponent);

            }
            return dez;
        } 
    }
}
