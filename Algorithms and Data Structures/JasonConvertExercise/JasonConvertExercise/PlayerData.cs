using System.Collections.Generic;

namespace JsonParser
{
    public class PlayerData
    {
        public string username;
        public string guild = "Gunners";
        public int level = 1;
        public int skinID = 5;
        public List<string> items = new List<string>();
    }
}