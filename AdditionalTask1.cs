using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class AdditionalTask1 : Form
    {
        private List<Color> colors =
        [
            Color.Black,
            Color.White,
            Color.Red,
            Color.Green,
            Color.Blue
        ];
        private List<string> fonts = new List<string>();
        public AdditionalTask1()
        {
            InitializeComponent();
            CreateFontsList();
            comboBox1.DataSource = colors;
            comboBox1.SelectedIndex = 0;
            textBox1.ForeColor = (Color)comboBox1.SelectedValue!;
        }
        private void CreateFontsList()
        {
            fonts = FontFamily.Families.Select(f => f.Name).ToList();
            listBox1.DataSource = fonts;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = (Color)comboBox1.SelectedValue!;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = listBox1.SelectedItem!.ToString()!;
            textBox1.Font = new Font(font, 9);
        }
    }
}
