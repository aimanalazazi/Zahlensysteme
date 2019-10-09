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
                Console.WriteLine("3: Aktion 3");

                Console.WriteLine("Aktion auswählen:");
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    // Umwandlung dezimal zu binär (spiegelverkehrte Ausgabe)
                    string eingabe, ausgabe="";
                    
                    Console.WriteLine("Dezimalzahl eingeben:");
                    eingabe = Console.ReadLine();
                    ausgabe = von10zu(ausgabe);

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
                    Console.WriteLine("Guten Tag.");
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

        static string von10zu(string input)
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
    }
}
