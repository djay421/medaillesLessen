using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht2
{
    internal class Opdracht2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke kamer wil je betreden?");
            Console.WriteLine("Keuken");
            Console.WriteLine("Woonkamer");
            Console.WriteLine("Slaapkamer");
            string kamerKeuze = Console.ReadLine();

            if (kamerKeuze == "Keuken")
            {
                Console.WriteLine("Je bent nu in de Keuken. Wil je naar de Woonkamer of het huis verlaten?");
                string keuzeKeuken = Console.ReadLine();

                if (keuzeKeuken == "Woonkamer")
                {
                    Console.WriteLine("Je bent nu in de Woonkamer. Wil je naar de Slaapkamer of de Keuken?");
                    string keuzeWoonkamer = Console.ReadLine();

                    if (keuzeWoonkamer == "Slaapkamer")
                    {
                        Console.WriteLine("Je bent nu in de Slaapkamer. Wil je terug naar de Woonkamer?");
                        string keuzeSlaapkamer = Console.ReadLine();

                        if (keuzeSlaapkamer == "Woonkamer")
                        {
                            Console.WriteLine("Je bent weer in de Woonkamer!");
                        }
                    }
                    else if (keuzeWoonkamer == "Keuken")
                    {
                        Console.WriteLine("Je bent weer in de Keuken!");
                    }
                }
                else if (keuzeKeuken == "verlaten")
                {
                    Console.WriteLine("Je bent weer terug bij het begin!");
                }
            }
            else if (kamerKeuze == "Woonkamer")
            {
                Console.WriteLine("Je bent nu in de Woonkamer. Wil je naar de Keuken of de Slaapkamer?");
                string keuzeWoonkamer = Console.ReadLine();

                if (keuzeWoonkamer == "Keuken")
                {
                    Console.WriteLine("Je bent nu in de Keuken. Wil je terug naar de Woonkamer?");
                    string keuzeKeuken = Console.ReadLine();

                    if (keuzeKeuken == "Woonkamer")
                    {
                        Console.WriteLine("Je bent weer in de Woonkamer!");
                    }
                }
                else if (keuzeWoonkamer == "Slaapkamer")
                {
                    Console.WriteLine("Je bent nu in de Slaapkamer. Wil je terug naar de Woonkamer?");
                    string keuzeSlaapkamer = Console.ReadLine();

                    if (keuzeSlaapkamer == "Woonkamer")
                    {
                        Console.WriteLine("Je bent weer in de Woonkamer!");
                    }
                }
            }
            else if (kamerKeuze == "Slaapkamer")
            {
                Console.WriteLine("Je bent nu in de Slaapkamer. Wil je naar de Woonkamer of het huis verlaten?");
                string keuzeSlaapkamer = Console.ReadLine();

                if (keuzeSlaapkamer == "Woonkamer")
                {
                    Console.WriteLine("Je bent nu in de Woonkamer. Wil je naar de Keuken of terug naar de Slaapkamer?");
                    string keuzeWoonkamer = Console.ReadLine();

                    if (keuzeWoonkamer == "Keuken")
                    {
                        Console.WriteLine("Je bent nu in de Keuken!");
                    }
                    else if (keuzeWoonkamer == "Slaapkamer")
                    {
                        Console.WriteLine("Je bent weer in de Slaapkamer!");
                    }
                }
                else if (keuzeSlaapkamer == "verlaten")
                {
                    Console.WriteLine("Je bent weer buiten het huis");
                }
            }
            else
            {
                Console.WriteLine("Heb je de goede kamer getypt?");
            }
        }


}
