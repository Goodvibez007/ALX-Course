namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CatchMeButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var top = rnd.NextInt64(1, 300);
            var left = rnd.NextInt64(1, 300);
            this.CatchMeButton.Location = new Point((int)top, (int)left);

        }
    }
}