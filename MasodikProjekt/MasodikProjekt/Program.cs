using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasodikProjekt.Models;

namespace MasodikProjekt
{
    class Program
    {
        //private static string name = "Bence";
        //private static  int age = 26;
        //private  static double weight = 90.5;

        static void Main(string[] args)
        {
            // procedurális:

            //string name = "Bence";
            //int age = 26;
            //double weight = 90.5;

            // Ezek összefüggő adatok -> egységbe kellene zárni...


            //double halfOfWeight = CalculateHalfOfWeight(weight);
            //int multipleAgeWithTwo = MultipleAgeWithTwo(age);

            //Console.WriteLine(halfOfWeight);
            //Console.WriteLine(multipleAgeWithTwo);


            // Ember osztály példányosítása

            // class neve (Ember -> típus) ember1 -> objketum neve = változó/objektum
            // értékadás: new + konstruktor hívás

            // Konsturktor az a metódus, ami az objektumot memóriában létrehozza ...

            // ha nincs egy osztálynak konstruktora, akkor a fordító csinál egy üreset...

            Ember ember = new Ember("Árpád", 12, 100);

            string emberNeve = ember.GetName();
            int emberEletkora = ember.GetAge();
            double emberTestsuly = ember.GetWeight();

            Console.WriteLine(emberNeve);
            Console.WriteLine(emberEletkora);
            Console.WriteLine(emberTestsuly);




            //Ember ember1 = null;
            //try
            //{
            //    ember1 = new Ember("Árpád", 47, -100);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    ember1 = new Ember();
            //}

            //Ember ember2 = null;
            //try
            //{
            //    ember2 = new Ember("Bence", -26, 90.5);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    ember2 = new Ember();
            //}

            //Console.WriteLine(ember1.GetName());
            //Console.WriteLine(ember1.GetAge());
            //Console.WriteLine(ember1.GetWeight());

            //Console.WriteLine(ember2.GetName());
            //Console.WriteLine(ember2.GetAge());
            //Console.WriteLine(ember2.GetWeight());

            //double halfOfWeight = CalculateHalfOfWeight(weight);
            //int multipleAgeWithTwo = MultipleAgeWithTwo(age);

            //Console.WriteLine(halfOfWeight);
            //Console.WriteLine(multipleAgeWithTwo);

            Console.ReadKey();
        }

        //static double CalculateHalfOfWeight(double weight)
        //{
        //    double result = weight / 2;
        //    return result;
        //}

        //static int MultipleAgeWithTwo(int age)
        //{
        //    int result = age * 2;
        //    return result;
        //}
    }
}
