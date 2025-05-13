using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RaceCommon;

namespace Race
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void getUserNameButton_Click(object sender, EventArgs e)
        {
            RaceGame f = new RaceGame(inputName.Text);
            f.Show();
            this.Hide();
        }
    }
}
