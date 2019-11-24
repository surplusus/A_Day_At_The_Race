using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRace
{
    class Guy
    {
        public string Name { get; }

        private const string NoWayText = "Not Enough Money";
        private Bet MyBet = null;
        public int Cash { get; set; }
        public RadioButton MyRadioButton;
        public readonly Label MyLabel;
        public Guy(string name, Label GuyName)
        {
            this.Name = name;
            this.MyLabel = GuyName;
        }
        public void UpdateLabels()
        {
            // set label to bet's description
            MyLabel.Text = this.Name;
            // label on radio button to show my cash
            MyRadioButton.Text = this.Name + " has " + Cash.ToString() + " Bucks";
        }
        public void ClearBet()
        {
            MyBet = null;
        }
        public bool PlaceBet(int Amount, int Dog)
        {
            // place new bet and store it my bet field
            MyBet = new Bet(this);
            // return true if having enough money
            if (Amount <= Cash)
            {
                MyBet.Amount = Amount;
                MyBet.Dog = Dog;
                return true;
            }
            else
            {
                MessageBox.Show(NoWayText, caption: "NO WAY!", MessageBoxButtons.OK);
                return false;
            }
        }
        public void Collect(int Winner)
        {
            // Ask my bet to pay out
            MyBet.PayOut(Winner);
        }
    }
}
