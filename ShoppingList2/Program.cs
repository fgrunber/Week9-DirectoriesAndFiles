using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Robin\samples\ShoppingList";
            string fileName = @"\\ShoppingList";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myshoppinglist = arrayFromFile.ToList<string>();


            Console.WriteLine("Sisesta mida sa soovid poest osta:");
            string useritems = Console.ReadLine();
            myshoppinglist.Add(useritems);

            File.WriteAllLines($"{fileLocation}{fileName}", myshoppinglist);
        }
    }
}
