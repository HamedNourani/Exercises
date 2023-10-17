namespace BreathOfTheWildEnemies
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var fireChuchu = new Chuchu<Fire>("Eldin Canyon", "Fire", 20, 3);
            fireChuchu.Attack();
        }
    }
}