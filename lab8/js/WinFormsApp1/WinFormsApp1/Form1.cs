using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ZodiacQuiz
{
    public partial class Form1 : Form
    {
        enum Zodiac
        {
            Овен, Телець, Близнюки, Рак, Лев, Діва,
            Терези, Скорпіон, Стрілець, Козеріг, Водолій, Риби
        }

        Dictionary<Zodiac, (string Стихія, string Атрибути)> zodiacData = new Dictionary<Zodiac, (string, string)>
        {
            { Zodiac.Овен, ("вогонь", "активність, починання") },
            { Zodiac.Телець, ("земля", "наполегливість, накопичення") },
            { Zodiac.Близнюки, ("повітря", "рух, комунікація") },
            { Zodiac.Рак, ("вода", "система, інтуїція") },
            { Zodiac.Лев, ("вогонь", "індивідуалізація, творче самовираження") },
            { Zodiac.Діва, ("земля", "служіння, деталізація") },
            { Zodiac.Терези, ("повітря", "врівноважування, дуальність") },
            { Zodiac.Скорпіон, ("вода", "трансформація, інстинктивність") },
            { Zodiac.Стрілець, ("вогонь", "світоглядність, духовність") },
            { Zodiac.Козеріг, ("земля", "відповідальність, цілеспрямованість") },
            { Zodiac.Водолій, ("повітря", "незалежність, новаторство") },
            { Zodiac.Риби, ("вода", "відречення, глибинність") }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();
            bool parsed = Enum.TryParse(input, ignoreCase: true, out Zodiac znak);

            if (parsed && zodiacData.ContainsKey(znak))
            {
                var info = zodiacData[znak];
                richTextBoxOutput.AppendText(
                    $"Знак: {znak}\nСтихія: {info.Стихія}\nАтрибути: {info.Атрибути}\n\n"
                );
            }
            else
            {
                MessageBox.Show("Невірний ввід! Введіть один з українських знаків зодіаку.");
            }

            textBox1.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}