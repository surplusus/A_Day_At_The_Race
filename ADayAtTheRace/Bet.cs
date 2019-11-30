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
        public int ExtraBet { get; set; }
        private readonly Guy Bettor = null;
        public Bet(Guy Bettor)
        {
            this.Bettor = Bettor;
        }
        ~Bet()
        {
            int n = 1;
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
            // parameter = winner horse of race
            // if the dog won, return the amout bet.
            if (this.Dog == Winner)
            {

                return Amount * ExtraBet;
            }
            // otherwise, return the negative of bet.
            else
            {
                return -Amount * ExtraBet;
            }
        }

    }
}
