namespace FakeSteam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var games = DataGenerator.GeneratePrices();
            var fakesteam = new SteamSystem("FakeSteam", games);



        }
    }
}