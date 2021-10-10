using Domain.Factories;
using System;
using System.Collections.Generic;

namespace Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CarFactory();
            var types = new List<string>() { "Audi", "Random", "Mercedes" };
            try
            {
                foreach (var type in types)
                {
                    Console.WriteLine($"Current car type is {factory.CreateCar(type).Type}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
