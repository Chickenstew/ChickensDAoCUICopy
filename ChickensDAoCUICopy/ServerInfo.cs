using System.Collections.Generic;

namespace ChickensDAoCUICopy
{
    public class ServerInfo
    {
        public static readonly Dictionary<string, List<string>> serverId = new Dictionary<string, List<string>>()
        {
            {"Atlas",new List<string>{ "Atlas", "-5.ini"} },
            {"phoenix", new List<string>{ "phoenix", "-41.ini"} },
            {"LotM", new List<string>{ "LotM", "-41.ini"} },
            {"eden", new List<string>{ "eden", "-41.ini"} },
            {"Blackthorn", new List<string>{ "Blackthorn", "-5.ini"} },
            {"OpenDAoC", new List<string>{ "Atlas", "-5.ini"} }

        };
        
    }
}
