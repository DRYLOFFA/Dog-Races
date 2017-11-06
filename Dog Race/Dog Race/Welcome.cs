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
    public partial class Welcome : Form
    {
        private bool _exiting;

        public Welcome()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Race g = new Race();
            g.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show(" Are you sure want to exit?" +
                                             "\n This will close the game!", "My First Application",
            MessageBoxButtons.OKCancel,
             MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                Application.Exit();
            }
        }
    }
}
