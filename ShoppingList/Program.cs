﻿using System;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Robin\samples";
            Directory.CreateDirectory($"{rootDirectory}\\ShoppingList");
            File.Create($"{rootDirectory}\\ShoppingList\\ShoppingList.txt");
        }
    }
}
