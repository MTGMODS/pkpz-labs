using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Recognizers.Text;
using Microsoft.Recognizers.Text.NumberWithUnit;
using Microsoft.Recognizers.Text.DateTime;
using Microsoft.Recognizers.Text.Sequence;

namespace RecognizerApp
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

                var results = new Dictionary<string, List<string>>();

                void AddResults(string label, List<ModelResult> recognized)
                {
                    if (recognized.Count == 0) return;
                    if (!results.ContainsKey(label))
                        results[label] = new List<string>();

                    foreach (var r in recognized)
                    {
                        string value = "";

                        if (r.Resolution != null)
                        {
                            if (r.Resolution.TryGetValue("value", out object val))
                            {
                                value = val?.ToString();
                            }
                            else if (r.Resolution.TryGetValue("values", out object valuesObj) &&
                                     valuesObj is List<Dictionary<string, string>> valuesList &&
                                     valuesList.Count > 0 &&
                                     valuesList[0].TryGetValue("value", out string valStr))
                            {
                                value = valStr;
                            }
                            else
                            {
                                value = r.Resolution.ToString();
                            }
                        }

                        results[label].Add($"{r.Text} – {value}");
                    }


                }

                var culture = Culture.English;

                AddResults("Валюта", NumberWithUnitRecognizer.RecognizeCurrency(inputText, culture));
                AddResults("Розмір/Вага/Маса", NumberWithUnitRecognizer.RecognizeDimension(inputText, culture));
                AddResults("Температура", NumberWithUnitRecognizer.RecognizeTemperature(inputText, culture));
                AddResults("Дата і час", DateTimeRecognizer.RecognizeDateTime(inputText, culture));
                AddResults("Телефон", SequenceRecognizer.RecognizePhoneNumber(inputText, culture));
                AddResults("IP-адреса", SequenceRecognizer.RecognizeIpAddress(inputText, culture));
                AddResults("Email", SequenceRecognizer.RecognizeEmail(inputText, culture));
                AddResults("URL", SequenceRecognizer.RecognizeURL(inputText, culture));
                AddResults("Хештеги", SequenceRecognizer.RecognizeHashtag(inputText, culture));

                List<string> outputLines = new List<string>();
                foreach (var category in results)
                {
                    outputLines.Add($"{category.Key} (знайдено: {category.Value.Count})");
                    outputLines.AddRange(category.Value);
                    outputLines.Add("");
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
