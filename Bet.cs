using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRace
{
    class Bet
    {
        public int Amount { get; set; }
        public int Dog { get; set; }
        private readonly Guy Bettor = null;
        public Bet(Guy Bettor)
        {
            this.Bettor = Bettor;
        }
        public string GetDescription()
        {
            // Return a string that says who placed bet
            // how much chsh was bet
            // which dog he bet on
            // if the aount is zero, "Joe hasn't placed a bet"

            return Bettor.Name + " hasn't placed a bet";
        }
        public int PayOut(int Winner)
        {
            // parameter = winner of race
            // if the dog won, return the amout bet.
            // otherwise, return the negative of bet.
            //if (Bettor.)
            return 0;
        }
    }
}
