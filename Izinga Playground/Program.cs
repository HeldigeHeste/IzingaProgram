using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izinga_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Spil();
            bool keepGoing = true;
            int choice;

            while (keepGoing)
            {
                choice = ShowMenu();

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Vælg spil");
                        break;
                    case 2:
                        Console.WriteLine("Vælg sværhedsgrad");
                        break;
                    case 3:
                        Console.WriteLine("Vis statistik");
                        break;
                    case 4:
                        Console.WriteLine("Skift navn");
                        break;
                    default:
                        Console.WriteLine("Du har vidst valgt forkert");
                        break;
                } // end switch
            } // end while loop

        }
        static int ShowMenu()
        {
            int input = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1) Vælg et spil");
            Console.WriteLine("2) Vælg sværhedsgrad");
            Console.WriteLine("3) Vis statistik");
            Console.WriteLine("4) Skift navn");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Forkert valg");
                input = 1;
            } // end try
            return input;
        } // end showMenu

        public static void Spil()
        {
            string[,] spil = new string[20, 3] { 
                { "spil1", "Beskrivelse", "Vippe" }, { "spil2", "Beskrivelse", "Vippe" }, 
                { "spil3", "Beskrivelse", "Gynge" }, { "spil4", "Beskrivelse", "Krav" }, 
                { "spil5", "Beskrivelse", "Krav" }, { "spil6", "Beskrivelse", "Krav" }, 
                { "spil7", "Beskrivelse", "Krav" }, { "spil8", "Beskrivelse", "Krav" }, 
                { "spil9", "Beskrivelse", "Krav" }, { "spil10", "Beskrivelse", "Krav" }, 
                { "spil11", "Beskrivelse", "Krav" }, { "spil12", "Beskrivelse", "Krav" }, 
                { "spil13", "Beskrivelse", "Krav" }, { "spil14", "Beskrivelse", "Krav" }, 
                { "spil15", "Beskrivelse", "Krav" }, { "spil16", "Beskrivelse", "Krav" }, 
                { "spil17", "Beskrivelse", "Krav" }, { "spil18", "Beskrivelse", "Krav" }, 
                { "spil19", "Beskrivelse", "Krav" }, { "spil20", "Beskrivelse", "Krav" }, };
        }
    }
}
