﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race
{
    class Dogs
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public string Name;
        public PictureBox MyPictureBox = null;
        public bool Winner = false;
        public int Location = 0;

        public Random Randomizer;

        public bool Run()
        {
            int move = Randomizer.Next(1, 6);
            Location = Location + move;
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RaceTrackLength)
            {
                Winner = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
