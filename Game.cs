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

        public Game(string id, string name, double price, DateTime release, string genre)
        {
            Id = id;
            Name = name;
            Price = price;
            Release = release;
            Genre = genre;
        }
    }
}
