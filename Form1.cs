namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        string rules = File.ReadAllText("rules.txt");
        int secretNumber;
        int tries = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rules, "Правила", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            acceptButton.Enabled = true;
            tries = 0;
            triesCountLabel.Text = tries.ToString();
            NumberNumericUpDown.Value = 0;
            secretNumber = random.Next(1, 101);

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            CheckNumber();
            triesCountLabel.Text = tries.ToString();
            NumberNumericUpDown.Value = 0;
        }

        private void CheckNumber()
        {
            if ((int)NumberNumericUpDown.Value > secretNumber)
            {
                MessageBox.Show("Указанное число больше загаданного!", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            else if ((int)NumberNumericUpDown.Value < secretNumber)
            {
                MessageBox.Show("Указанное число меньше загаданного!", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show($"Вы угадали число!\nЧисло : {secretNumber}\nПопыток : {tries}", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                acceptButton.Enabled = false;
                return;
            }
            tries++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acceptButton.Enabled = false;
        }
    }
}
