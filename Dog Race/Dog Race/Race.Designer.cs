namespace Dog_Race
{
    partial class Race
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.BtnRace = new System.Windows.Forms.Button();
            this.gbBets = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbZak = new System.Windows.Forms.Label();
            this.lbMary = new System.Windows.Forms.Label();
            this.lbJim = new System.Windows.Forms.Label();
            this.tbZakBet = new System.Windows.Forms.TextBox();
            this.tbMaryBet = new System.Windows.Forms.TextBox();
            this.tbJimBet = new System.Windows.Forms.TextBox();
            this.nudDog = new System.Windows.Forms.NumericUpDown();
            this.nudBet = new System.Windows.Forms.NumericUpDown();
            this.rbZak = new System.Windows.Forms.RadioButton();
            this.rbMary = new System.Windows.Forms.RadioButton();
            this.rbJim = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.gbBets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.BackColor = System.Drawing.Color.White;
            this.btnPlaceBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBet.Location = new System.Drawing.Point(12, 491);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(300, 59);
            this.btnPlaceBet.TabIndex = 3;
            this.btnPlaceBet.Text = "PLACE BET";
            this.btnPlaceBet.UseVisualStyleBackColor = false;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(687, 491);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(300, 59);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "NEXT RACE";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BtnRace
            // 
            this.BtnRace.BackColor = System.Drawing.Color.White;
            this.BtnRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRace.Location = new System.Drawing.Point(348, 491);
            this.BtnRace.Name = "BtnRace";
            this.BtnRace.Size = new System.Drawing.Size(300, 59);
            this.BtnRace.TabIndex = 6;
            this.BtnRace.Text = "RACE";
            this.BtnRace.UseVisualStyleBackColor = false;
            this.BtnRace.Click += new System.EventHandler(this.BtnRace_Click);
            // 
            // gbBets
            // 
            this.gbBets.BackColor = System.Drawing.Color.DodgerBlue;
            this.gbBets.Controls.Add(this.label2);
            this.gbBets.Controls.Add(this.label1);
            this.gbBets.Controls.Add(this.lbZak);
            this.gbBets.Controls.Add(this.lbMary);
            this.gbBets.Controls.Add(this.lbJim);
            this.gbBets.Controls.Add(this.tbZakBet);
            this.gbBets.Controls.Add(this.tbMaryBet);
            this.gbBets.Controls.Add(this.tbJimBet);
            this.gbBets.Controls.Add(this.nudDog);
            this.gbBets.Controls.Add(this.nudBet);
            this.gbBets.Controls.Add(this.rbZak);
            this.gbBets.Controls.Add(this.rbMary);
            this.gbBets.Controls.Add(this.rbJim);
            this.gbBets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBets.Location = new System.Drawing.Point(12, 333);
            this.gbBets.Name = "gbBets";
            this.gbBets.Size = new System.Drawing.Size(975, 141);
            this.gbBets.TabIndex = 3;
            this.gbBets.TabStop = false;
            this.gbBets.Enter += new System.EventHandler(this.gbBets_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Dog to bet on:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select how much to bet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbZak
            // 
            this.lbZak.AutoSize = true;
            this.lbZak.Location = new System.Drawing.Point(95, 108);
            this.lbZak.Name = "lbZak";
            this.lbZak.Size = new System.Drawing.Size(35, 16);
            this.lbZak.TabIndex = 10;
            this.lbZak.Text = "Test";
            // 
            // lbMary
            // 
            this.lbMary.AutoSize = true;
            this.lbMary.Location = new System.Drawing.Point(95, 68);
            this.lbMary.Name = "lbMary";
            this.lbMary.Size = new System.Drawing.Size(35, 16);
            this.lbMary.TabIndex = 9;
            this.lbMary.Text = "Test";
            // 
            // lbJim
            // 
            this.lbJim.AutoSize = true;
            this.lbJim.Location = new System.Drawing.Point(95, 25);
            this.lbJim.Name = "lbJim";
            this.lbJim.Size = new System.Drawing.Size(35, 16);
            this.lbJim.TabIndex = 8;
            this.lbJim.Text = "Test";
            // 
            // tbZakBet
            // 
            this.tbZakBet.Location = new System.Drawing.Point(635, 105);
            this.tbZakBet.Name = "tbZakBet";
            this.tbZakBet.ReadOnly = true;
            this.tbZakBet.Size = new System.Drawing.Size(320, 22);
            this.tbZakBet.TabIndex = 97;
            // 
            // tbMaryBet
            // 
            this.tbMaryBet.Location = new System.Drawing.Point(635, 65);
            this.tbMaryBet.Name = "tbMaryBet";
            this.tbMaryBet.ReadOnly = true;
            this.tbMaryBet.Size = new System.Drawing.Size(320, 22);
            this.tbMaryBet.TabIndex = 98;
            // 
            // tbJimBet
            // 
            this.tbJimBet.Location = new System.Drawing.Point(635, 25);
            this.tbJimBet.Name = "tbJimBet";
            this.tbJimBet.ReadOnly = true;
            this.tbJimBet.Size = new System.Drawing.Size(320, 22);
            this.tbJimBet.TabIndex = 99;
            // 
            // nudDog
            // 
            this.nudDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudDog.Location = new System.Drawing.Point(559, 81);
            this.nudDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDog.Name = "nudDog";
            this.nudDog.Size = new System.Drawing.Size(51, 22);
            this.nudDog.TabIndex = 2;
            this.nudDog.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudBet
            // 
            this.nudBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudBet.Location = new System.Drawing.Point(559, 40);
            this.nudBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBet.Name = "nudBet";
            this.nudBet.Size = new System.Drawing.Size(51, 22);
            this.nudBet.TabIndex = 1;
            this.nudBet.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // rbZak
            // 
            this.rbZak.AutoSize = true;
            this.rbZak.BackColor = System.Drawing.Color.White;
            this.rbZak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbZak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbZak.Location = new System.Drawing.Point(21, 106);
            this.rbZak.Name = "rbZak";
            this.rbZak.Size = new System.Drawing.Size(68, 20);
            this.rbZak.TabIndex = 5;
            this.rbZak.TabStop = true;
            this.rbZak.Text = "Zak    ";
            this.rbZak.UseVisualStyleBackColor = false;
            this.rbZak.CheckedChanged += new System.EventHandler(this.rbZak_CheckedChanged);
            // 
            // rbMary
            // 
            this.rbMary.AutoSize = true;
            this.rbMary.BackColor = System.Drawing.Color.White;
            this.rbMary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMary.Location = new System.Drawing.Point(21, 65);
            this.rbMary.Name = "rbMary";
            this.rbMary.Size = new System.Drawing.Size(68, 20);
            this.rbMary.TabIndex = 4;
            this.rbMary.TabStop = true;
            this.rbMary.Text = "Mary  ";
            this.rbMary.UseVisualStyleBackColor = false;
            this.rbMary.CheckedChanged += new System.EventHandler(this.rbMary_CheckedChanged);
            // 
            // rbJim
            // 
            this.rbJim.AutoSize = true;
            this.rbJim.BackColor = System.Drawing.Color.White;
            this.rbJim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbJim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJim.Location = new System.Drawing.Point(21, 25);
            this.rbJim.Name = "rbJim";
            this.rbJim.Size = new System.Drawing.Size(70, 20);
            this.rbJim.TabIndex = 1;
            this.rbJim.TabStop = true;
            this.rbJim.Text = "Jim     ";
            this.rbJim.UseVisualStyleBackColor = false;
            this.rbJim.CheckedChanged += new System.EventHandler(this.rbJim_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 16);
            this.label3.TabIndex = 9001;
            this.label3.Text = "All bets are final. Once a bet is made you can not retract from the bet. Good Luc" +
    "k.\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.White;
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(889, 15);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(38, 281);
            this.btnPlayAgain.TabIndex = 9007;
            this.btnPlayAgain.Text = "P\r\nL\r\nA\r\nY\r\n\r\nA\r\nG\r\nA\r\nI\r\nN";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(949, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 281);
            this.btnExit.TabIndex = 9008;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E\r\nX\r\nI\r\nT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbDog3
            // 
            this.pbDog3.BackColor = System.Drawing.Color.Transparent;
            this.pbDog3.BackgroundImage = global::Dog_Race.Properties.Resources.Dog4;
            this.pbDog3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDog3.Location = new System.Drawing.Point(22, 256);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(85, 35);
            this.pbDog3.TabIndex = 9006;
            this.pbDog3.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.BackColor = System.Drawing.Color.Transparent;
            this.pbDog2.BackgroundImage = global::Dog_Race.Properties.Resources.Dog3;
            this.pbDog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDog2.Location = new System.Drawing.Point(22, 176);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(85, 35);
            this.pbDog2.TabIndex = 9005;
            this.pbDog2.TabStop = false;
            // 
            // pbDog1
            // 
            this.pbDog1.BackColor = System.Drawing.Color.Transparent;
            this.pbDog1.BackgroundImage = global::Dog_Race.Properties.Resources.Dog2;
            this.pbDog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDog1.Location = new System.Drawing.Point(22, 98);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(85, 35);
            this.pbDog1.TabIndex = 9004;
            this.pbDog1.TabStop = false;
            // 
            // pbDog
            // 
            this.pbDog.BackColor = System.Drawing.Color.Transparent;
            this.pbDog.BackgroundImage = global::Dog_Race.Properties.Resources.Dog1;
            this.pbDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDog.Location = new System.Drawing.Point(22, 20);
            this.pbDog.Name = "pbDog";
            this.pbDog.Size = new System.Drawing.Size(85, 35);
            this.pbDog.TabIndex = 9003;
            this.pbDog.TabStop = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbRaceTrack.BackgroundImage = global::Dog_Race.Properties.Resources.GrassFin1;
            this.pbRaceTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRaceTrack.Location = new System.Drawing.Point(12, 15);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(861, 281);
            this.pbRaceTrack.TabIndex = 9002;
            this.pbRaceTrack.TabStop = false;
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbDog);
            this.Controls.Add(this.pbRaceTrack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbBets);
            this.Controls.Add(this.BtnRace);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceBet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Race";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Day";
            this.Load += new System.EventHandler(this.Race_Load);
            this.gbBets.ResumeLayout(false);
            this.gbBets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button BtnRace;
        private System.Windows.Forms.GroupBox gbBets;
        private System.Windows.Forms.Label lbZak;
        private System.Windows.Forms.Label lbMary;
        private System.Windows.Forms.Label lbJim;
        private System.Windows.Forms.TextBox tbZakBet;
        private System.Windows.Forms.TextBox tbMaryBet;
        private System.Windows.Forms.TextBox tbJimBet;
        private System.Windows.Forms.NumericUpDown nudDog;
        private System.Windows.Forms.NumericUpDown nudBet;
        private System.Windows.Forms.RadioButton rbZak;
        private System.Windows.Forms.RadioButton rbMary;
        private System.Windows.Forms.RadioButton rbJim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.PictureBox pbDog;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        //private System.Windows.Forms.Timer timer1;
    }
}

