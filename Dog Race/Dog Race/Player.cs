using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race
{

    class Player : Dogs
    {
        public new string Name { get; set; }
        public int Balance { get; set; }
        public int Bet { get; set; }
        public int Dog { get; set; }

        public void WinBet()
        {
            Balance = Balance + (2 * Bet);
        }
        public void LooseBet()
        {
            Balance = Balance - Bet;
        }
        public string PrintMessage()
        {
            string message = Name + " places bet of $" + Bet + " on dog " + Dog;
            return message;
        }
        public string GameOver()
        {
            string message = Name + " has gone BUST. Has $" + Balance + " left and is unable to bet";
            return message;
        }
    }
}