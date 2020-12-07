using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class AlienPack
    {
        private Alien[] aliens;

        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien alien, int atIndex)
        {
            aliens[atIndex] = alien;
        }

        public int CalculateDamage()
        {
            int total = 0;
            foreach (Alien a in aliens)
            {
                total += a.GetDamage();
            }

            return total;

        }
    }
}
