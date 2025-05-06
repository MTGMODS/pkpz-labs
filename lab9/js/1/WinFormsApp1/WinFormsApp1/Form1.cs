using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab9_List
{
    public partial class Form1 : Form
    {
        List<int> L = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            textBoxBefore.Clear();
            textBoxAfter.Clear();

            string filePath = "input.txt";
            if (!File.Exists(filePath))
            {
                
                var rand = new Random();
                File.WriteAllLines(filePath, Enumerable.Range(0, 20).Select(_ => rand.Next(1, 20).ToString()));
            }

            L = File.ReadAllLines(filePath)
                    .Where(line => int.TryParse(line, out _))
                    .Select(int.Parse)
                    .ToList();

            textBoxBefore.Text = string.Join(" ", L);

            if (!int.TryParse(textBoxElement.Text, out int E))
            {
                MessageBox.Show("Введіть ціле число для елемента E.");
                return;
            }

            
            List<int> removed = new List<int>();
            for (int i = 0; i < L.Count - 1;)
            {
                if (L[i] == E)
                {
                    removed.Add(L[i + 1]);
                    L.RemoveAt(i + 1);
                }
                else
                {
                    i++;
                }
            }

            
            L.InsertRange(0, removed);

            textBoxAfter.Text = string.Join(" ", L);

           
            File.WriteAllLines("output.txt",
                Enumerable.Range(0, (int)Math.Ceiling(L.Count / 10.0))
                .Select(i => string.Join(" ", L.Skip(i * 10).Take(10))));
        }
    }
}
