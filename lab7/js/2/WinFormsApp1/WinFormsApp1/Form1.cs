using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab7_ZNAK
{
    public partial class Form1 : Form
    {
        private struct ZNAK
        {
            public string NAME;
            public string ZODIAC;
            public DateTime BDAY;

            public override string ToString()
            {
                return $"{NAME}, {ZODIAC}, {BDAY:dd.MM.yyyy}";
            }
        }

        private List<ZNAK> BOOK = new List<ZNAK>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                string zodiac = textBoxZodiac.Text;
                string[] parts = textBoxBDay.Text.Split('.');
                int day = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                int year = int.Parse(parts[2]);

                DateTime bday = new DateTime(year, month, day);

                ZNAK person = new ZNAK { NAME = name, ZODIAC = zodiac, BDAY = bday };
                BOOK.Add(person);

                listBoxData.Items.Add(person.ToString());

                textBoxName.Clear();
                textBoxZodiac.Clear();
                textBoxBDay.Clear();
            }
            catch
            {
                MessageBox.Show("Неправильний формат дати. Використовуйте ДД.ММ.РРРР");
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            var sorted = BOOK.OrderByDescending(p => p.BDAY).ToList();
            listBoxData.Items.Clear();
            foreach (var p in sorted)
                listBoxData.Items.Add(p.ToString());
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower();
            var found = BOOK.Where(p => p.NAME.ToLower().Contains(search)).ToList();

            if (found.Count > 0)
            {
                MessageBox.Show(string.Join("\n", found.Select(p => p.ToString())));
            }
            else
            {
                MessageBox.Show("Людину не знайдено.");
            }
        }
    }
}
