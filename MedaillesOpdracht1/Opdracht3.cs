using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Opdracht3
    {
        public void Start()
        {
            Console.WriteLine("Wat is het weer nu?");
            Console.WriteLine(" ");
            Console.WriteLine("Bewolkt");
            Console.WriteLine("Zonnig");
            Console.WriteLine("Regen");
            Console.WriteLine(" ");

            string weer = Console.ReadLine();

            Console.WriteLine("Hoeveel graden is het?");

            int tempratuur = Convert.ToInt32(Console.ReadLine());

            if (weer == "Zonnig" && tempratuur > 20)
            {
                Console.WriteLine("Je hebt geen jas nodig vandaag, geniet lekker van de zon!");
            }
            else if (weer == "Zonnig" && tempratuur < 20)
            {
                Console.WriteLine("Je hebt echt wel een jas nodig vandaag.. Maar zonnebrand kan alsnog verstandig zijn!");
            }
            else if (weer == "Bewolkt" && tempratuur > 20)
            {
                Console.WriteLine("Het is warm maar bewolkt, een lichte jas kan handig zijn maar niet per se nodig.");
            }
            else if (weer == "Bewolkt" && tempratuur < 20)
            {
                Console.WriteLine("Het is fris en bewolkt, neem zeker een jas mee om warm te blijven.");
            }
            else if (weer == "Regen" && tempratuur > 20)
            {
                Console.WriteLine("Het is warm maar regenachtig, een regenjas of paraplu is slim.");
            }
            else if (weer == "Regen" && tempratuur < 20)
            {
                Console.WriteLine("Koud en regenachtig... jas én paraplu zijn vandaag echt onmisbaar!");
            }else
            {
                Console.WriteLine("Je hebt geen geldige informatie gegeven. probeer het opnieuw.");
            }

        }
    }
}
