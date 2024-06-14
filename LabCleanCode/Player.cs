using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCleanCode
{
    public class Player
    {
        int totalGuesses;
        public string Name { get; private set; }
        public int Games { get; private set; }
        
        public Player(string name, int guesses)
        {
            Name = name;
            Games = 1;
            totalGuesses = guesses;
        }

        public void Update(int guesses)
        {
            totalGuesses += guesses;
            Games++;
        }
        public double Average()
        {
            return (double)totalGuesses / Games;
        }
        public override bool Equals(Object p)
        {
            return Name.Equals(((Player)p).Name);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
