﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RedTotalFromShoppingList
{
    class Program
    {
        public class Item
        {
            string name;
            int price;

            public Item(string _name, int _price)
            {
                name = _name;
                price = _price;
                Console.WriteLine($"Item {name} created ");
            }
            public string Name { get { return name; } }

            public int Price { get { return price; } }
        }
       static void Main(string[] args)
       {
            Console.WriteLine("Soldier");
            ReadFromShoppingList();
       }
        public static void ReadFromShoppingList()
        {
            string filePath = @"C:\Users\opilane\Samples";
            string fileName = @"shoppingList.txt";

            List<Item> shoppingItems = new List<Item>();

            List<string> linesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

            foreach (string line in linesFromFile)
            {
                string[] temparray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Item newItem = new Item(temparray[0], Int32.Parse(temparray[1]));
                shoppingItems.Add(newItem); 
            }
            Console.WriteLine($"YOUR SHOPPING CART IS FULL FATTO >:(");
            foreach(Item item in shoppingItems)
            {
                Console.WriteLine($"Item: {item.Name}; Price: {item.Price}");
            }
        }
    } 
}
