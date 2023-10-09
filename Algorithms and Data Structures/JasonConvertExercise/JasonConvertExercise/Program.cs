using System;
using System.Collections.Generic;

namespace JasonParserExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Parse();
        }

        private static void Parse()
        {
            try
            {
                string playerDataJson = Console.ReadLine();
                var playerDataDeserializer = new PlayerDataDeserializer();
                var convertedPlayerData = playerDataDeserializer.DeserializePlayerData(playerDataJson);

                if (convertedPlayerData.username == null)
                {
                    Console.WriteLine("username is a necessary field and cannot be null!");
                    Parse();
                }
                else if (convertedPlayerData.level == 0)
                {
                    convertedPlayerData.level = 1;
                }
                
                Console.WriteLine(convertedPlayerData.username);
                Console.WriteLine(convertedPlayerData.level);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid data! Please enter valid data.");
                Parse();
            }
        }
    }
}