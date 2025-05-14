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
