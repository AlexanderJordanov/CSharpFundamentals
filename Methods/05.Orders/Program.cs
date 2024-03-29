﻿using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            OrderPrice(product, quantity);
        }

        private static void OrderPrice(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = quantity * 1.5; break;
                case "water":
                    price = quantity * 1; break;
                case "coke":
                    price = quantity * 1.4; break;
                case "snacks":
                    price = quantity * 2; break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
