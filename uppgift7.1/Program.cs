using System;
using System.Collections.Generic;
using System.Xml;

namespace uppgift_7_1
{
    class program
    {
        static void Main(string[] args)
        {
            string namn = "";
            List<string> namnlista = new List<string>();
            do
            {
                Console.WriteLine("Skriv in ett namn eller en tom rad om du vill avsluta");
                namn = Console.ReadLine().ToLower();
                if (namn != "")
                {
                    namnlista.Add(namn);
                }
            } while (namn != "");
            namnlista.Sort();
            Console.WriteLine("Namnen i bokstavsordning fast baklänges");
            for (int i = namnlista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(namnlista[i]);
            }
        }
    }
}
