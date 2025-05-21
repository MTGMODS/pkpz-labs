using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Recognizers.Text;
using Microsoft.Recognizers.Text.Number;

namespace OrdinalRecognizerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string inputText = File.ReadAllText(ofd.FileName);
                txtInput.Text = inputText;

                var results = NumberRecognizer.RecognizeOrdinal(inputText, Culture.English);
                List<string> outputLines = new List<string>();
                outputLines.Add($"Кількість порядкових числівників: {results.Count}");

                foreach (var result in results)
                {
                    var value = result.Resolution["value"];
                    outputLines.Add($"{result.Text} – {value}");
                }

                txtOutput.Lines = outputLines.ToArray();

      
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files|*.txt";
                sfd.Title = "Зберегти результати";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sfd.FileName, outputLines);
                }
            }
        }
    }
}
