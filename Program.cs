using System;
namespace PracticeLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            var gameNames = new List<string>()  {"TheBiggestGame", "CODA" ,"GTAEE", "Mortal Combat", "TheSecondBiggestGame"};
            var collection = gameNames.OrderBy(n => n.Length).ToList();
            foreach (var name in collection)
            {
                Console.WriteLine(name);    
            }

        }
    }
}
