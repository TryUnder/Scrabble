using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Domain.Entities
{
    public class Tile
    {
        public char Letter { get; }
        public int Points { get; }
        public Tile(char letter, int points)
        {
            Letter = letter;
            Points = points;
        }
    }
}
