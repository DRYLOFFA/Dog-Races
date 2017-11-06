using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race
{

    public partial class Race : Form
    {
        Player Jim;
        Player Mary;
        Player Zak;

        int winningdog;

        Dogs[] dogsArray = new Dogs[4];
        private Timer timer1;

        public string winningDog;

        public decimal Test;

        Player[] guyArray = new Player[3];

        Random Randomizer = new Random();
        private bool _exiting;

        public Race()
        {
            InitializeComponent();

            dogsArray[0] = new Dogs() { MyPictureBox = pbDog, Name = "Dog 1", RaceTrackLength = pbRaceTrack.Width - pbDog.Width, StartingPosition = pbDog.Left, Randomizer = Randomizer };
            dogsArray[1] = new Dogs() { MyPictureBox = pbDog1, Name = "Dog 2", RaceTrackLength = pbRaceTrack.Width - pbDog.Width, StartingPosition = pbDog1.Left, Randomizer = Randomizer };
            dogsArray[2] = new Dogs() { MyPictureBox = pbDog2, Name = "Dog 3", RaceTrackLength = pbRaceTrack.Width - pbDog.Width, StartingPosition = pbDog2.Left, Randomizer = Randomizer };
            dogsArray[3] = new Dogs() { MyPictureBox = pbDog3, Name = "Dog 4", RaceTrackLength = pbRaceTrack.Width - pbDog.Width, StartingPosition = pbDog3.Left, Randomizer = Randomizer };

        }

        private void Race_Load(object sender, EventArgs e)
        {
            Jim = new Player();
            Jim.Name = "Jim";
            Jim.Balance = 50;

            Mary = new Player();
            Mary.Name = "Mary";
            Mary.Balance = 50;

            Zak = new Player();
            Zak.Name = "Zak";
            Zak.Balance = 50;

            refreshBalances();
            BtnRace.Enabled = false;
            btnPlaceBet.Enabled = false;
            btnReset.Enabled = false;
            btnPlayAgain.Enabled = false;
        }
        public void refreshBalances()
        {
            lbJim.Text = Jim.Name + "'s current balance is $" + Jim.Balance;
            lbMary.Text = Mary.Name + "'s current balance is $" + Mary.Balance;
            lbZak.Text = Zak.Name + "'s current balance is $" + Zak.Balance;
        }
        public void NoBal()
        {
            if (Jim.Balance == 0)
            {
                rbJim.Enabled = false;
                tbJimBet.Text = Jim.GameOver();
            }
            if (Mary.Balance == 0)
            {
                rbMary.Enabled = false;
                tbMaryBet.Text = Mary.GameOver();
            }
            if (Zak.Balance == 0)
            {
                rbZak.Enabled = false;
                tbZakBet.Text = Zak.GameOver();
            }
            if (Jim.Balance == 0 && Mary.Balance == 0 && Zak.Balance == 0)
            {
                btnPlayAgain.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceBet_Click(object sender, EventArgs e)
        {
            if (rbJim.Checked)
            {
                btnPlaceBet.Enabled = false;
                Jim.Bet = Convert.ToInt16(nudBet.Text);
                Jim.Dog = Convert.ToInt16(nudDog.Text);
                tbJimBet.Text = Jim.PrintMessage();
                Jim.LooseBet();
                refreshBalances();
                rbJim.Enabled = false;
                if (rbJim.Enabled == false)
                {
                    btnPlaceBet.Enabled = false;
                }

            }
            if (rbMary.Checked)
            {
                btnPlaceBet.Enabled = true;
                Mary.Bet = Convert.ToInt16(nudBet.Text);
                Mary.Dog = Convert.ToInt16(nudDog.Text);
                tbMaryBet.Text = Mary.PrintMessage();
                Mary.LooseBet();
                refreshBalances();
                rbMary.Enabled = false;
                if (rbMary.Enabled == false)
                {
                    btnPlaceBet.Enabled = false;
                }

            }
            if (rbZak.Checked)
            {
                btnPlaceBet.Enabled = true;
                Zak.Bet = Convert.ToInt16(nudBet.Text);
                Zak.Dog = Convert.ToInt16(nudDog.Text);
                tbZakBet.Text = Zak.PrintMessage();
                Zak.LooseBet();
                refreshBalances();
                rbZak.Enabled = false;
                if (rbZak.Enabled == false)
                {
                    btnPlaceBet.Enabled = false;
                }
            }
            if ((rbJim.Enabled == false) && (rbMary.Enabled == false) && (rbZak.Enabled == false))
            {
                BtnRace.Enabled = true;
            }
            rbJim.Checked = false;
            rbMary.Checked = false;
            rbZak.Checked = false;
            btnPlaceBet.Enabled = false;

        }

        private void BtnRace_Click(object sender, EventArgs e)
        {
            dogsArray[0].TakeStartingPosition();
            dogsArray[1].TakeStartingPosition();
            dogsArray[2].TakeStartingPosition();
            dogsArray[3].TakeStartingPosition();
            timer1.Start();
            BtnRace.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbJimBet.Clear();
            tbMaryBet.Clear();
            tbZakBet.Clear();
            rbJim.Enabled = true;
            rbMary.Enabled = true;
            rbZak.Enabled = true;
            rbJim.Checked = false;
            rbMary.Checked = false;
            rbZak.Checked = false;
            refreshBalances();
            NoBal();
            btnPlaceBet.Enabled = false;
            BtnRace.Enabled = false;
            btnReset.Enabled = false;
            dogsArray[0].TakeStartingPosition();
            dogsArray[1].TakeStartingPosition();
            dogsArray[2].TakeStartingPosition();
            dogsArray[3].TakeStartingPosition();

            Jim.Bet = 0;
            Mary.Bet = 0;
            Zak.Bet = 0;
        }

        private void rbJim_CheckedChanged(object sender, EventArgs e)
        {
            nudBet.Maximum = 15;
            nudBet.Minimum = 5;
            nudBet.Value = 15;
            if (Jim.Balance <= Convert.ToInt16(nudBet.Maximum))
            {
                nudBet.Maximum = Jim.Balance;
                nudBet.Minimum = 5;
            }
            else
            {
                nudBet.Maximum = 15;
                nudBet.Minimum = 5;
            }
            btnPlaceBet.Enabled = true;
        }

        private void rbMary_CheckedChanged(object sender, EventArgs e)
        {
            nudBet.Maximum = 15;
            nudBet.Minimum = 5;
            nudBet.Value = 15;
            if (Mary.Balance <= Convert.ToInt16(nudBet.Maximum))
            {
                nudBet.Maximum = Mary.Balance;
                nudBet.Minimum = 5;
            }
            btnPlaceBet.Enabled = true;
        }

        private void rbZak_CheckedChanged(object sender, EventArgs e)
        {
            nudBet.Maximum = 15;
            nudBet.Minimum = 5;
            nudBet.Value = 15;
            if (Zak.Balance <= Convert.ToInt16(nudBet.Maximum))
            {
                nudBet.Maximum = Zak.Balance;
                nudBet.Minimum = 5;
            }
            else
            {
                nudBet.Maximum = 15;
                nudBet.Minimum = 5;
            }
            btnPlaceBet.Enabled = true;
        }

        private void gbBets_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dogsArray.Length; i++)
            {

                dogsArray[i].Run();
                if (dogsArray[i].Run() == true)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show(dogsArray[i].Name + " has won the race!!" +
                                                        "\nClick OK to collect any winnings");
                    winningDog = dogsArray[i].Name;
                    winningdog = i + 1;
                    i = dogsArray.Length;

                    if (winningdog == Jim.Dog)
                    {
                        Jim.WinBet();
                        refreshBalances();
                    }
                    if (winningdog == Mary.Dog)
                    {
                        Mary.WinBet();
                        refreshBalances();
                    }
                    if (winningdog == Zak.Dog)
                    {
                        Zak.WinBet();
                        refreshBalances();
                    }
                    btnReset.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Race NewForm = new Race();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show(" Are you sure want to exit?" +
                                             "\n All bets and balances will be lost!", "My First Application",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                this.Close();
                var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Welcome);
                if (formToShow != null)
                {
                    formToShow.Show();
                }
                //Application.Exit();
            }
        }
    }
}
