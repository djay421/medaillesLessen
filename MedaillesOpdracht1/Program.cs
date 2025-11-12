using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("hallo");
            Console.WriteLine("Wat is je naam?: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Wat is leeftijd?: ");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoi, jouw naam is " + naam + " en je bent " + leeftijd + " jaar oud");
        }
    }
}
