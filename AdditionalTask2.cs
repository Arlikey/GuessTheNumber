using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuessTheNumber
{
    public partial class AdditionalTask2 : Form
    {
        private bool isClicked = false;
        public AdditionalTask2()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isClicked)
            {

                toolStripProgressBar.PerformStep();
                if (toolStripProgressBar.Value >= toolStripProgressBar.Maximum)
                {
                    isClicked = false;
                    MessageBox.Show("ProgressBar заполнен!");

                }
            }
            SetTime();
        }

        private void AdditionalTask2_Load(object sender, EventArgs e)
        {
            timer.Start();
            SetTime();
        }

        public void SetTime()
        {
            toolStripStatusLabel.Text = DateTime.Now.ToString("T");
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            isClicked = true;
            toolStripProgressBar.Value = 0;
        }
    }
}
