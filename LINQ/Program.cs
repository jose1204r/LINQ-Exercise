using System.Collections.Generic;
using System.Linq;


namespace LINQ



{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "PacMan", "GOD of War", "Call of Duty", "Alien", "Halo Infinity" };
            videoGames.Where (names => names == "");

            Console.WriteLine("************GAMES LIST ***************");

            foreach (var game in videoGames)
            {
                
                
                Console.WriteLine(game);


            }
        }
    }
}
