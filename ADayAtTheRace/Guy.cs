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
        public Bet MyBet = null;
        public int Cash { get; set; }
        public RadioButton MyRadioButton;
        public readonly Label MyLabel;
        private readonly TextBox MyTextBox;
        public Guy(string name, Label GuyName, TextBox textBox, RadioButton radioButton)
        {
            this.Cash = 20;
            this.Name = name;
            this.MyLabel = GuyName;
            this.MyRadioButton = radioButton;
            this.MyTextBox = textBox;
        }
        public void UpdateLabels()
        {
            // set label to bet's description
            MyLabel.Text = this.Name;
            // label on radio button to show my cash
            MyRadioButton.Text =  string.Format("{0} has {1} Busks", this.Name, this.Cash.ToString());
            //MyRadioButton.Text = this.Name + " has " + Cash.ToString() + " Bucks";
        }
        public void ClearBet()
        {
            MyBet = null;
            MyTextBox.Text = string.Format($"{this.Name}돈 걸 준비하시고~");
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
                MyTextBox.Text = string.Format("{0} bets {1} on horse #{2}"
                    , this.Name, this.MyBet.Amount, this.MyBet.Dog + 1);
                return true;
            }
            return false;
        }
        public void Collect(int Winner)
        {
            // Ask my bet to pay out
            this.Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }

}
