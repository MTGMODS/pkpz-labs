using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BusParkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<(string Name, int Year, int Mileage, int Seats)> busList = new();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if (!int.TryParse(textBoxYear.Text, out int year) ||
                !int.TryParse(textBoxMileage.Text, out int mileage) ||
                !int.TryParse(textBoxSeats.Text, out int seats))
            {
                MessageBox.Show("Невірні числові значення.");
                return;
            }

            busList.Add((name, year, mileage, seats));
            listBoxOutput.Items.Add($"Додано: {name}, {year}, {mileage} км, {seats} місць");
        }

        private void buttonEligible_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int count = 0;

            foreach (var bus in busList)
            {
                if (currentYear - bus.Year <= 10)
                    count++;
            }

            MessageBox.Show($"Кількість транспортних засобів, що можуть їхати міжобласно: {count}");
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            foreach (var bus in busList)
            {
                listBoxOutput.Items.Add($"{bus.Name}, {bus.Year}, {bus.Mileage} км, {bus.Seats} місць");
            }
        }
    }
}