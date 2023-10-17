using System;
using System.Collections.Generic;

namespace BreathOfTheWildEnemies
{
    public class Keese<Element> : Enemy<Element> where Element : new()
    {
        public Keese(string location, string weapon, int health, int threat)
        {
            Location = location;
            Weapon = weapon;
            Health = health;
            Threat = threat;
            Type = new Element();
        }

        public override void Attack()
        {
            Console.WriteLine($"{Type}chuchu is attacking");
        }
    }
}