/// Homework No. 10  	Exercise Part 1
/// File Name: Alien
/// @author: Evan Sinclair
/// Date:  Nov 30, 2020
///
/// Problem Statement: There is an Alien class to represent a monster and an AlienPack class that represents a band of
/// aliens and how much damage they can inflict. Rewrite the code so that inheritance is used to represent the different 
/// types of aliens instead of the “type” parameter.  This should result in deletion of the “type” parameter.  Also 
/// rewrite the Alien class to hide the instance variables and create a GetDamage method for each derived class that
/// returns the amount of damage the alien inflicts.  Finally, rewrite the CalculateDamage method to use GetDamage and
/// write a Main method that tests the code.
/// 
/// Overall Plan:
/// 1) Create abstract alien class with abstract method GetDamage()
/// 2) Create child classes for alien types that extend alien class
/// 3) Create alienpack class that contains alien[] and can calculate total pack damage with CalculateDamage()
/// 4) Create a driver program to test out functionality.
///

using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlienPack omicron = new AlienPack(5);
            Alien alien1 = new SnakeAlien();
            Alien alien2 = new SnakeAlien();
            Alien alien3 = new OgreAlien();
            Alien alien4 = new MarshAlien();
            Alien alien5 = new MarshAlien();

            omicron.AddAlien(alien1, 0);
            omicron.AddAlien(alien2, 1);
            omicron.AddAlien(alien3, 2);
            omicron.AddAlien(alien4, 3);
            omicron.AddAlien(alien5, 4);

            Console.WriteLine(omicron.CalculateDamage());

        }
    }
}
