using System;
using HarmadikProjekt.Models;

namespace HarmadikProjekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Object-initializer synthax

            // prop = "Valami" akkor setter
            // ha változó = prop. akkor getter

            Ember ember = new Ember
            {
                Name = "Árpád",
                Age = 47,
                Weight = 100
            };

            Console.WriteLine(ember.Name);
            Console.WriteLine(ember.Age);
            Console.WriteLine(ember.Weight);

            Console.WriteLine(ember.Köszön());

            Console.ReadKey();
        }
    }
}
