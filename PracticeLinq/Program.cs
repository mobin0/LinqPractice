using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videogames = new List<string>() {
            "Ratchet and Clank",
            "Jak and Daxter",
            "Runescape"
            };
            IEnumerable<string> results = videogames.OrderBy(x => x.Length);

            foreach (string i in results) {
                Console.WriteLine(i);
            }
        }
    }
}
