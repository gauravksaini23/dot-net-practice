using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Players.Factory
{
    public class Player
    {
        string Name { get; set; }
        readonly List<Player> players;
        public Player()
        {
            players = new List<Player>();
        }
        public void Add()
        {
            Console.WriteLine("Please enter player name");
            var name = Console.ReadLine();
            players.Add(new Player { Name = name ?? "" });
            Show();
            Add();
        }

        void Show()
        {
            foreach (Player player in players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
