using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeSteam
{
    internal class DataGenerator
    {

        public static List<string> Name { get; set; } = new List<string>()
        {
        "CS:Gay Offensive", "Cyberpunk 1945", "GTA X", "Fornetti", "Dog off Duty", "Alza Legends" , "Lyfestyle 2093", "Flight Simulator 2001", "Tractor Simulator ","Flirting Simulator 2025" ,"Fall Boys", "Dead Berlin", "Truck Simulator"
        };
        public static List<string> Id { get; set; } = new List<string>()
        {
         "0945","5896","8702","3647","0156","9112","1569","9699","8652","0548","8852","0002","1945"
        };

        public static List<string> Genre { get; set; } = new List<string>()
        {
         "Anime", "Simulator", "RPG", "FPS","Multiplayer" 
        };
        

        public static List<Game> GeneratePrices(int numberOfPrices)
        {

            var random = new Random();
            var game = new List<Game>();

              for (int i = 0; i < Name.Count; i++)

            {
                var price = random.Next(0,100);
                var name = Name[i];
                var id = Id[i];
                var Genre = random.Next(0,5);


            }










        }






















    }
}
