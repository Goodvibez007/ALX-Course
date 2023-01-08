namespace LottoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            Number1.BackColor = Color.WhiteSmoke;
            Number2.BackColor = Color.WhiteSmoke;
            Number3.BackColor = Color.WhiteSmoke;
            Number4.BackColor = Color.WhiteSmoke;
            Number5.BackColor = Color.WhiteSmoke;
            Number6.BackColor = Color.WhiteSmoke;
            
            Random rnd = new Random();

            List<int> matchList = new List<int>();
            matchList.Clear();

            int[] winningNumbers = new int[6];
            winningNumbers[0] = rnd.Next(50);

            int i = rnd.Next(50);
            while (winningNumbers.Contains(i))
            {
                i = rnd.Next(50);
            }
            winningNumbers[1] = i;

            i = rnd.Next(50);
            while (winningNumbers.Contains(i))
            {
                i = rnd.Next(50);
            }
            winningNumbers[2] = i;

            i = rnd.Next(50);
            while (winningNumbers.Contains(i))
            {
                i = rnd.Next(50);
            }
            winningNumbers[3] = i;

            i = rnd.Next(50);
            while (winningNumbers.Contains(i))
            {
                i = rnd.Next(50);
            }
            winningNumbers[4] = i;

            i = rnd.Next(50);
            while (winningNumbers.Contains(i))
            {
                i = rnd.Next(50);
            }
            winningNumbers[5] = i;

            Number1.Text = winningNumbers[0].ToString();
            Number2.Text = winningNumbers[1].ToString();
            Number3.Text = winningNumbers[2].ToString();
            Number4.Text = winningNumbers[3].ToString();
            Number5.Text = winningNumbers[4].ToString();
            Number6.Text = winningNumbers[5].ToString();

            if (betNumbers.Contains(winningNumbers[0]))
            {
                Number1.BackColor = Color.Green;
                matchList.Add(winningNumbers[0]);
            }                
            if (betNumbers.Contains(winningNumbers[1]))
            {
                Number2.BackColor = Color.Green;
                matchList.Add(winningNumbers[1]);
            }                
            if (betNumbers.Contains(winningNumbers[2]))
            {
                Number3.BackColor = Color.Green;
                matchList.Add(winningNumbers[2]);
            }                
            if (betNumbers.Contains(winningNumbers[3]))
            {
                Number4.BackColor = Color.Green;
                matchList.Add(winningNumbers[3]);
            }                
            if (betNumbers.Contains(winningNumbers[4]))
            {
                Number5.BackColor = Color.Green;
                matchList.Add(winningNumbers[4]);
            }                            
            if (betNumbers.Contains(winningNumbers[5]))
            {
                Number6.BackColor = Color.Green;
                matchList.Add(winningNumbers[5]);
            }

            if (matchList.Count == 3)
                MessageBox.Show("Congratulation! You won 3!");
            else if (matchList.Count == 4)
                MessageBox.Show("Congratulation! You won 4!\nWell done!");
            else if (matchList.Count == 5)
                MessageBox.Show("Congratulation!!! You won 5!\nYou lucky bastard!");
            else if (matchList.Count == 6)
                MessageBox.Show("CONGRATULATION!!! You won 6!\nIf it was real you would be very rich!");
        }

        List<int> betNumbers = new List<int>();

        private void ButtonsClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (betNumbers.Count != 6)
            {
                if (!betNumbers.Contains(Int32.Parse(button.Text)))
                {
                    betNumbers.Add(Int32.Parse(button.Text));
                    button.BackColor = Color.Green;
                }
                else
                {
                    betNumbers.Remove(Int32.Parse(button.Text));
                    button.BackColor = Color.Transparent;
                }
            }
            else
            {
                if (!betNumbers.Contains(Int32.Parse(button.Text)))
                {
                    MessageBox.Show("You can bet only six numbers.\nUnmark some numbers to change your bet.");
                }
                else
                {
                    betNumbers.Remove(Int32.Parse(button.Text));
                    button.BackColor = Color.Transparent;
                }
            }
        }
    }
}