namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Super Mario Bros",
                "Stardew Valley",
                "Animal Crossing",
                "Legend of Zelda",
                "Wordle",

            };

            List<string> orderGAmes = videoGames.OrderBy(game => game.Length).ToList();

            foreach (string game in orderGAmes)
            {
                Console.WriteLine(game);
            }

        }
    }
}
