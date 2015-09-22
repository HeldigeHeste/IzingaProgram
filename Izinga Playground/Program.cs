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
            //            string[,] spil = Spil();
            //            string[,] remedier = Remedier();

            //            Spil();
            //            Remedier();

            string[,] spil = new string[20, 3]{
                { "spil 1", "Beskrivelse", "Vippe" }, { "spil 2", "Beskrivelse", "Vippe" },
                { "spil 3", "Beskrivelse", "Gynge" }, { "spil 4", "Beskrivelse", "Vippe" },
                { "spil 5", "Beskrivelse", "Vippe" }, { "spil 6", "Beskrivelse", "Gynge" },
                { "spil 7", "Beskrivelse", "Rutsjebane" }, { "spil 8", "Beskrivelse", "Rutsjebane" },
                { "spil 9", "Beskrivelse", "Rutsjebane" }, { "spil 10", "Beskrivelse", "Gynge" },
                { "spil 11", "Beskrivelse", "Klatrevæg" }, { "spil 12", "Beskrivelse", "Vippe" },
                { "spil 13", "Beskrivelse", "Vippe" }, { "spil 14", "Beskrivelse", "Klatrevæg" },
                { "spil 15", "Beskrivelse", "Vippe" }, { "spil 16", "Beskrivelse", "Gynge" },
                { "spil 17", "Beskrivelse", "Rutsjebane" }, { "spil 18", "Beskrivelse", "Vippe" },
                { "spil 19", "Beskrivelse", "Vippe" }, { "spil 20", "Beskrivelse", "Klatrevæg" } };

            string[,] remedier = new string[4, 2] {
                { "Gynge", "false" },
                { "Vippe", "true" },
                { "Rutsjebane", "true" },
                { "Klatrevæg", "false" } };

            bool keepGoing = true;
            int choice;

            while (keepGoing)
            {
                choice = ShowMenu();

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Liste af mulige spil");
                        muligeSpil(spil,remedier);
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
                    case 9:
                        Console.WriteLine("Ændre remedier");
                        writeRemedier(remedier);
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

        static void muligeSpil(string[,] spil, string[,] remedier)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (spil[i,2]==remedier[j,0])
                    {
                        if (remedier[j, 1]=="true")
                        {
                            Console.WriteLine(spil[i, 0]);
                        }
                    }
                }
            }
        }

        static string[,] Spil()
        {
            string[,] array1 = new string[20, 3]{
                { "spil1", "Beskrivelse", "Vippe" }, { "spil2", "Beskrivelse", "Vippe" }, 
                { "spil3", "Beskrivelse", "Gynge" }, { "spil4", "Beskrivelse", "Vippe" }, 
                { "spil5", "Beskrivelse", "Vippe" }, { "spil6", "Beskrivelse", "Gynge" }, 
                { "spil7", "Beskrivelse", "Rutsjebane" }, { "spil8", "Beskrivelse", "Rutsjebane" }, 
                { "spil9", "Beskrivelse", "Rutsjebane" }, { "spil10", "Beskrivelse", "Gynge" }, 
                { "spil11", "Beskrivelse", "Klatrevæg" }, { "spil12", "Beskrivelse", "Vippe" }, 
                { "spil13", "Beskrivelse", "Vippe" }, { "spil14", "Beskrivelse", "Klatrevæg" }, 
                { "spil15", "Beskrivelse", "Vippe" }, { "spil16", "Beskrivelse", "Gynge" }, 
                { "spil17", "Beskrivelse", "Rutsjebane" }, { "spil18", "Beskrivelse", "Vippe" }, 
                { "spil19", "Beskrivelse", "Vippe" }, { "spil20", "Beskrivelse", "Klatrevæg" } };
            return array1;
        }
        static string[,] Remedier()
        {
            string[,] array2 = new string[4, 2] { 
                { "Gynge", "false" }, 
                { "Vippe", "true" }, 
                { "Rutsjebane", "true" }, 
                { "Klatrevæg", "false" } };
            return array2;
        }

        static void writeRemedier(string[,] rem)
        {
            bool boolAdmin = true;
            while (boolAdmin)
            {
                Console.WriteLine("Status for aktiverede remedier:");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("{0}. {1} status: \t{2}", i+1, rem[i,0], rem[i,1]);
                }

                Console.WriteLine("Hvis du vil ændre status på et redskab, marker med en tast");
                Console.WriteLine("for at vende tilbage til hovedmenuen tast 0");

                int adminInput = Convert.ToInt32(Console.ReadLine());
                if (0 < adminInput && adminInput < 5)
                {
                    if (rem[adminInput - 1, 1] == "true")
                    {
                        rem[adminInput - 1, 1] = "false";
                    }
                    else if (rem[adminInput - 1, 1] == "false")
                    {
                        rem[adminInput - 1, 1] = "true";
                    }
                }
                else if (adminInput == 0)
                {
                    boolAdmin = false;
                }
            }
        }


    }
}
