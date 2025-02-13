using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Domain.Entities
{
    public class Game
    {
        public Guid GameId { get; set; }
        public Board Board { get; set; }
        public Tuple<Player, Player> Players { get; set; }
        public int currentPlayerIndex { get; set; }

        public Game()
        {
            GameId = Guid.NewGuid();
            Board = new Board();
            Players = Tuple.Create<Player, Player>(null, null);
        }
    }
}
