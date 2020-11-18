using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasodikProjekt.Models
{
    class Ember : Object
    {
        private string name;
        private int age;
        private double weight;

        private void SetName(string name)
        {
            if (name == "")
                throw new Exception("Név nem lehet üres");

            this.name = name;
        }

        private void SetAge(int age)
        {
            if (age < 0)
                throw new Exception("Életkor nem lehet negatív");

            this.age = age;
        }

        private void SetWeight(double weight)
        {
            if (weight < 0)
                throw new Exception("Testsúly nem lehet negatív");

            this.weight = weight;
        }

        /// <summary>
        /// Konstruktor
        /// csak public lehet
        /// nincs visszatérési érték (se void, int, double)
        /// a neve meg kell egyezzen az osztály nevével...
        /// MINDIG A KONSTRUKTOR FUT LE ELŐSZÖR
        /// </summary>
        public Ember(string name, int age, double weight)
        {
            SetName(name);
            SetAge(age);
            SetWeight(weight);
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        //double CalculateHalfOfWeight()
        //{
        //    double result = weight / 2;
        //    return result;
        //}

        //int MultipleAgeWithTwo()
        //{
        //    int result = age * 2;
        //    return result;
        //}
    }
}
