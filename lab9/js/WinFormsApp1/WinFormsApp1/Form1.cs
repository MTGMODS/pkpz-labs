using System;
using System.IO;
using System.Windows.Forms;

namespace Lab9_Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string expression = File.ReadAllText("expression.txt");
            int[] stack = new int[expression.Length];
            int top = -1;
            string result = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    top++;
                    stack[top] = i;
                }
                else if (expression[i] == ')')
                {
                    if (top == -1)
                    {
                        result = "Unbalanced";
                        break;
                    }
                    result += $"({stack[top] + 1}, {i + 1})\n";
                    top--;
                }
            }

            if (top != -1) result = "Unbalanced";
            if (string.IsNullOrEmpty(result)) result = "Balanced but no pairs";
            textBoxResult.Text = result;
        }
    }
}