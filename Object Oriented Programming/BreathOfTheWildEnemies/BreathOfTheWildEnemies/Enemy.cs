using System.Collections.Generic;

namespace BreathOfTheWildEnemies
{
    public abstract class Enemy<T>
    {
        public T Type { get; set; }
        public string Location { get; set; }
        public string Weapon { get; set; }
        public int Health { get; set; }
        public int Threat { get; set; }

        public virtual void Attack()
        {

        }
    }
}