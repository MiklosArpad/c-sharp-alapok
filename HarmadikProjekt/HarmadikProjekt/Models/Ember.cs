using System;

namespace HarmadikProjekt.Models
{
    public class Ember
    {
        // Adattagok állapotok
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        // Metódus/függvény: viselkedés
        public string Köszön()
        {
            int hour = DateTime.Now.Hour;

            if (hour < 12)
                return "Jó reggelt!";

            if (hour > 12 && hour < 20)
                return "Jó napot!";

            return "Jó estét!";
        }
    }
}
