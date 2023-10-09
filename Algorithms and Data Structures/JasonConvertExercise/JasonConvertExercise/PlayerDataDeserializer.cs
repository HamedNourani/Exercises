using Newtonsoft.Json;

namespace JasonParserExercise
{
    public class PlayerDataDeserializer
    {
        public PlayerData DeserializePlayerData(string playerDataJson)
        {
            var convertedPlayerData = JsonConvert.DeserializeObject<PlayerData>(playerDataJson);
            
            return convertedPlayerData;
        }
    }
}