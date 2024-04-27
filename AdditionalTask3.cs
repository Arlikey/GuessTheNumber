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
    public partial class AdditionalTask3 : Form
    {
        ToolStripMenuItem[] colors = {
            new ToolStripMenuItem(){Text = "Red"},
            new ToolStripMenuItem(){Text = "Blue"},
            new ToolStripMenuItem(){Text = "Green"},
            new ToolStripMenuItem(){Text = "Yellow"},
        };
        public AdditionalTask3()
        {
            InitializeComponent();

            foreach (ToolStripMenuItem item in colors)
            {
                item.Click += ColorChange_Click;
            }

            contextMenuStrip1.Items.AddRange(colors);

            panel1.ContextMenuStrip = contextMenuStrip1;
        }

        private void ColorChange_Click(object? sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            panel1.BackColor = SetColor(item);
        }

        private Color SetColor(ToolStripMenuItem item) => item.Text switch
        {
            "Red" => Color.Red,
            "Blue" => Color.Blue,
            "Green" => Color.Green,
            "Yellow" => Color.Yellow,
            _ => Color.White
        };
    }
}
