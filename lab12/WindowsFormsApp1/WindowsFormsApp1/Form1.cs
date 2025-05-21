using Microsoft.Recognizers.Text;
using Microsoft.Recognizers.Text.Number;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                txtInput.Text = text;

                var results = NumberRecognizer.RecognizeNumber(text, Culture.English);

                lstResults.Items.Clear();

         
                StringBuilder outputText = new StringBuilder();

                foreach (var result in results)
                {
                    string recognizedText = result.Text;
                    string startIndex = result.Start.ToString();
                    string endIndex = result.End.ToString();
                    string value = result.Resolution["value"].ToString();

                    string resultEntry =
                        $"Розпізнаний текст (число): {recognizedText}\n" +
                        $"Початковий індекс у рядку: {startIndex}\n" +
                        $"Кінцевий індекс у рядку: {endIndex}\n" +
                        $"Розпізнане значення числа: {value}\n";

                    lstResults.Items.Add($"Розпізнаний текст (число): {recognizedText}");
                    lstResults.Items.Add($"Початковий індекс у рядку: {startIndex}");
                    lstResults.Items.Add($"Кінцевий індекс у рядку: {endIndex}");
                    lstResults.Items.Add($"Розпізнане значення числа: {value}");
                    lstResults.Items.Add("");

                    outputText.AppendLine(resultEntry);
                }

                File.WriteAllText("output.txt", outputText.ToString());
                MessageBox.Show("Результат записано у файл output.txt", "Готово");
            }
        }

    }
}
