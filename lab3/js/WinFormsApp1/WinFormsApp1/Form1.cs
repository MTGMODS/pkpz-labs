using System;
using System.Windows.Forms;

namespace AtCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            int count = 0;
            foreach (char c in input)
                if (c == '@') count++;

            labelResult.Text = $"Кількість '@': {count}";
        }
    }
}
