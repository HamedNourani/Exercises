using System;
using System.Collections.Generic;

namespace JsonParser
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
                    return;
                }
                
                Console.WriteLine(convertedPlayerData.username);
                Console.WriteLine(convertedPlayerData.guild);
                Console.WriteLine(convertedPlayerData.level);
                Console.WriteLine(convertedPlayerData.skinID);

                foreach (var item in convertedPlayerData.items)
                {
                    Console.Write($"{item}  ");
                }
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