using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    internal class dice
    {
        public int RollDice()
        {
            Random random = new Random();

            // Generate a random number between 1 and 6
            int Die1 = random.Next(1, 7);
            int Die2 = random.Next(1, 7);
            int sum = Die1 + Die2;
            return sum;
        }
    }
}
