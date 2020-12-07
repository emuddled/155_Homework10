using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    abstract class Alien
    {
        private string name;
        private int health;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetHealth(int health)
        {
            this.health = health;
        }
        public abstract int GetDamage();
    }

    class SnakeAlien : Alien
    {
        public SnakeAlien()
        {
            SetHealth(100);
            SetName("Viper");
            
        }
        public SnakeAlien(string name, int health)
        {
            SetHealth(health);
            SetName(name);


        }
        public override int GetDamage()
        {
            return 10;
        }
    }

    class OgreAlien : Alien
    {
        public OgreAlien()
        {
            SetHealth(100);
            SetName("Grug");


        }
        public OgreAlien(string name, int health)
        {
            SetHealth(health);
            SetName(name);


        }
        public override int GetDamage()
        {
            return 6;
        }
    }
    class MarshAlien : Alien
    {
        public MarshAlien()
        {
            SetHealth(100);
            SetName("StayPuff");

        }
        public MarshAlien(string name, int health)
        {
            SetHealth(health);
            SetName(name);

        }
        public override int GetDamage()
        {
            return 1;
        }

    }

}
