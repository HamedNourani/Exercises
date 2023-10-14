using Newtonsoft.Json;

namespace JsonParser
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