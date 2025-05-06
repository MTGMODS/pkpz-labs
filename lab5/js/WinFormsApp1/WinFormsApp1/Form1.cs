using System;
using System.IO;
using System.Windows.Forms;

namespace PlanetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatePlanet_Click(object sender, EventArgs e)
        {
            // Створення планети з введених даних
            Planet planet = new Planet
            {
                Name = txtName.Text,
                Diameter = Convert.ToDouble(txtDiameter.Text),
                Mass = Convert.ToDouble(txtMass.Text),
                HasRings = chkHasRings.Checked,
                NumMoons = Convert.ToInt32(txtNumMoons.Text),
                Type = txtType.Text,
                DistanceFromSun = Convert.ToDouble(txtDistanceFromSun.Text)
            };

            // Виведення інформації на екран
            planet.DisplayInfo();
            planet.SaveToFile();
        }
    }

    // Клас планети
    public class Planet
    {
        private string name;
        private double diameter; // діаметр планети в км
        private double mass; // маса планети в кг
        private bool hasRings;
        private int numMoons;
        private string type; // тип планети (газова, кам'яниста)
        private double distanceFromSun; // відстань від Сонця в млн км

        // Властивості для доступу до полів
        public string Name { get => name; set => name = value; }
        public double Diameter { get => diameter; set => diameter = value; }
        public double Mass { get => mass; set => mass = value; }
        public bool HasRings { get => hasRings; set => hasRings = value; }
        public int NumMoons { get => numMoons; set => numMoons = value; }
        public string Type { get => type; set => type = value; }
        public double DistanceFromSun { get => distanceFromSun; set => distanceFromSun = value; }

        // Конструктор без параметрів
        public Planet()
        {
            name = "Unknown";
            diameter = 0;
            mass = 0;
            hasRings = false;
            numMoons = 0;
            type = "Unknown";
            distanceFromSun = 0;
        }

        // Метод для збереження даних в текстовий файл
        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter("planet_data.txt"))
            {
                sw.WriteLine($"Planet Name: {name}");
                sw.WriteLine($"Diameter: {diameter} km");
                sw.WriteLine($"Mass: {mass} kg");
                sw.WriteLine($"Has Rings: {hasRings}");
                sw.WriteLine($"Number of Moons: {numMoons}");
                sw.WriteLine($"Type: {type}");
                sw.WriteLine($"Distance from Sun: {distanceFromSun} million km");
            }
        }

        // Метод для виведення інформації про планету
        public void DisplayInfo()
        {
            MessageBox.Show($"Planet Name: {name}\nDiameter: {diameter} km\nMass: {mass} kg\n" +
                $"Has Rings: {hasRings}\nNumber of Moons: {numMoons}\nType: {type}\n" +
                $"Distance from Sun: {distanceFromSun} million km");
        }
    }
}
