using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    internal class coin
    {
    }
 class Coin
    {
        Random rand = new Random(); // Random number generator for tossing the coin.
        private string sideUp; // Field to store the current side facing up.
        // Constructor to initialize the coin with a default side.
        public Coin()
        {
            sideUp = "Heads"; // Default side.
        }
        // Method to simulate tossing the coin.
        public void Toss()
        {
            Random rand = new Random();
            int tossResult = rand.Next(2); // Generate a random number (0 or 1).
            if (tossResult == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }
        // Method to get the current side facing up.
        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
