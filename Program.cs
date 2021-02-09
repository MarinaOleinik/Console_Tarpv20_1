using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tarpv20_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a_= Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a={0}, b={1}",a_,b);
            double c = (a_ + b) / (6 * a_ - 4 * b);
            Console.WriteLine("c={0}", c.ToString());

            Random rnd = new Random();
            int hinne = rnd.Next(1, 7);
            Console.WriteLine("Hinne: {0}", hinne);
            Console.ReadLine();
            string tekst="???";
            switch (hinne)
            {
                case 1: tekst = "Õpi veel!";break;
                case 2: tekst = "Õpi natuke veel!"; break;
                case 3: tekst = "Rahuldav!"; break;
                case 4: tekst = "Hea!"; break;
                case 5: tekst = "Väga hea!"; break;
                default:
                    tekst = "Viga!";
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(tekst);
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                nupp = Console.ReadKey();

            } while (nupp.Key!=ConsoleKey.Backspace);

            Console.ReadLine();
            Console.WriteLine("Töö failidega:");
            string a;
            Console.WriteLine("Y-on vaja salvestada failisse");
            Console.WriteLine("N-on vaja lugeda failist");
            nupp = Console.ReadKey();
            if (nupp.Key==ConsoleKey.Y)
            {
                StreamWriter file = new StreamWriter(@"..\..\texts.txt",true);
                file.WriteLine(hinne + " " + tekst);
                file.Close();
                a = hinne + " " + tekst;
                Console.WriteLine("Failisse oli salvestatud: {0}",a);
            }
            else if (nupp.Key==ConsoleKey.N)
            {
                //Math.Max(arv1, aarv2);
                Console.WriteLine("Failis on järgmine informatsion:");
                StreamReader filist = new StreamReader(@"..\..\texts.txt");
                a = filist.ReadToEnd();
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Puhkame");
            }

            Console.ReadLine();
        }

    }
}
