using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MedaillesOpdracht
{
    internal class Opdracht5
    {
        public void Run()
        {
            List<string> namen = new List<string>();
            List<int> getallen = new List<int>();
            List<bool> status = new List<bool>();

            namen.Add("Sven");
            namen.Add("Amira");
            namen.Add("Noah");

            getallen.Add(5);
            getallen.Add(15);
            getallen.Add(25);

            status.Add(true);
            status.Add(false);
            status.Add(true);

            Console.WriteLine("Namen:");
            foreach (string naam in namen)
            {
                Console.WriteLine(naam);
            }

            Console.WriteLine("\nGetallen:");
            foreach (int getal in getallen)
            {
                Console.WriteLine(getal);
            }

            Console.WriteLine("\nStatus:");
            foreach (bool s in status)
            {
                Console.WriteLine(s);
            }
        }
    }
}