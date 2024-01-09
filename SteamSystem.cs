using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeSteam
{
    internal class SteamSystem
    {
        public string Name { get; set; }
        public List<Game>  Games { get; set; } 



        public SteamSystem(string name, List<Game> games)
        {
            Name = name;
            Games = games;

             
        }
    }

}
      