using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ClinicApp
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        struct CabinetRecord
        {
            public string Name;
            public int Number;
            public string Doctor;
            public int Day;
            public TimeSpan Start;
            public TimeSpan End;

            public override string ToString() =>
                $"{Name} (#{Number}), {Doctor}, День: {Day}, {Start} - {End} ({(End - Start).TotalMinutes} хв)";
        }

        private List<CabinetRecord> records = new();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var record = new CabinetRecord
                {
                    Name = textBoxName.Text,
                    Number = int.Parse(textBoxNumber.Text),
                    Doctor = textBoxDoctor.Text,
                    Day = int.Parse(textBoxDay.Text),
                    Start = TimeSpan.ParseExact(textBoxStart.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture),
                    End = TimeSpan.ParseExact(textBoxEnd.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture)
                };
                records.Add(record);
                MessageBox.Show("Додано!");
            }
            catch
            {
                MessageBox.Show("Перевір формат введення!");
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            foreach (var r in records)
                listBoxOutput.Items.Add(r.ToString());
        }

        private void buttonCheckF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxQueryDay.Text) || string.IsNullOrWhiteSpace(textBoxQueryTime.Text))
            {
                MessageBox.Show("Введіть день та час для перевірки.");
                return;
            }

            try
            {
                int day = int.Parse(textBoxQueryDay.Text);
                var time = TimeSpan.ParseExact(textBoxQueryTime.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture);

                var found = records.FirstOrDefault(r =>
                    r.Name.ToLower().Contains("флюорограф") &&
                    r.Day == day &&
                    r.Start <= time && time <= r.End);

                MessageBox.Show(found.Name != null ? "Кабінет працює" : "Кабінет не працює");
            }
            catch
            {
                MessageBox.Show("Невірний формат даних. День — ціле число, час — у форматі ГГ:ХХ:СС.");
            }
        }

        private void buttonFridayDoctors_Click(object sender, EventArgs e)
        {
            var result = records.Where(r =>
                r.Day == 5 && r.Start >= new TimeSpan(12, 0, 0)).ToList();
            listBoxOutput.Items.Clear();
            foreach (var r in result)
                listBoxOutput.Items.Add(r.ToString());
        }

        private void buttonLateTherapist_Click(object sender, EventArgs e)
        {
            var today = (int)DateTime.Now.DayOfWeek;
            today = today == 0 ? 7 : today;
            var result = records
                .Where(r => r.Day == today && r.Doctor.ToLower().Contains("терапевт"))
                .OrderByDescending(r => r.End)
                .FirstOrDefault();
            MessageBox.Show(result.Name != null ? result.ToString() : "Немає терапевтів сьогодні");
        }

        private void buttonTomorrowStaff_Click(object sender, EventArgs e)
        {
            var tomorrow = ((int)DateTime.Now.AddDays(1).DayOfWeek);
            tomorrow = tomorrow == 0 ? 7 : tomorrow;
            var result = records.Where(r =>
                r.Day == tomorrow &&
                r.Start < new TimeSpan(12, 0, 0) &&
                r.End > new TimeSpan(12, 0, 0)).ToList();

            listBoxOutput.Items.Clear();
            foreach (var r in result)
                listBoxOutput.Items.Add(r.ToString());
        }

        
        
        
        
        private void buttonDemo_Click(object sender, EventArgs e)
        {
            records.Clear();
            records.Add(new CabinetRecord
            {
                Name = "Флюорографія",
                Number = 101,
                Doctor = "Іваненко І.І.",
                Day = 5,
                Start = new TimeSpan(13, 0, 0),
                End = new TimeSpan(16, 30, 0)
            });

            records.Add(new CabinetRecord
            {
                Name = "Терапія",
                Number = 202,
                Doctor = "Петренко П.П. (терапевт)",
                Day = ((int)DateTime.Today.DayOfWeek + 1) % 7 == 0 ? 7 : ((int)DateTime.Today.DayOfWeek + 1) % 7,
                Start = new TimeSpan(9, 0, 0),
                End = new TimeSpan(18, 0, 0)
            });

            records.Add(new CabinetRecord
            {
                Name = "Ортопедія",
                Number = 303,
                Doctor = "Сидоренко С.С.",
                Day = 5,
                Start = new TimeSpan(11, 0, 0),
                End = new TimeSpan(14, 0, 0)
            });

            records.Add(new CabinetRecord
            {
                Name = "Хірургія",
                Number = 404,
                Doctor = "Коваленко К.К.",
                Day = 6,
                Start = new TimeSpan(10, 0, 0),
                End = new TimeSpan(13, 30, 0)
            });

            records.Add(new CabinetRecord
            {
                Name = "ЛОР",
                Number = 505,
                Doctor = "Зеленський З.З.",
                Day = 7,
                Start = new TimeSpan(8, 30, 0),
                End = new TimeSpan(11, 30, 0)
            });

            buttonShowAll_Click(null, null); // показати одразу
        }
        
        
    }
}
