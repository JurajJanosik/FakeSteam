using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeSteam
{
    internal class Game
    {
      

        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Release { get; set; }
        public string Genre { get; set; }
        public int Players { get; set; }

        public Game(string id, string name, double price, DateTime release, string genre, int players )
        {
            Id = id;
            Name = name;
            Price = price;
            Release = release;
            Genre = genre;
            Players = players;
        }

        override
        public string ToString()
        {
            string ret = string.Empty;
            ret = "ID: " + Id + " Name: " + Name + " Price: " + Price + " Genre: " + Genre + " Release: " + Release + " Players: " + Players;
            return ret;
        }
    }
}
