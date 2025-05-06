namespace BusParkApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.TextBox textBoxSeats;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEligible;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.ListBox listBoxOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.textBoxSeats = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEligible = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.PlaceholderText = "Назва транспорту";
            this.textBoxName.Size = new System.Drawing.Size(200, 23);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(12, 41);
            this.textBoxYear.PlaceholderText = "Рік випуску";
            this.textBoxYear.Size = new System.Drawing.Size(200, 23);
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(12, 70);
            this.textBoxMileage.PlaceholderText = "Пробіг (км)";
            this.textBoxMileage.Size = new System.Drawing.Size(200, 23);
            // 
            // textBoxSeats
            // 
            this.textBoxSeats.Location = new System.Drawing.Point(12, 99);
            this.textBoxSeats.PlaceholderText = "Кількість місць";
            this.textBoxSeats.Size = new System.Drawing.Size(200, 23);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(230, 12);
            this.buttonAdd.Size = new System.Drawing.Size(120, 23);
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEligible
            // 
            this.buttonEligible.Location = new System.Drawing.Point(230, 41);
            this.buttonEligible.Size = new System.Drawing.Size(120, 23);
            this.buttonEligible.Text = "Перевірити";
            this.buttonEligible.Click += new System.EventHandler(this.buttonEligible_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(230, 70);
            this.buttonShowAll.Size = new System.Drawing.Size(120, 23);
            this.buttonShowAll.Text = "Показати всі";
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Location = new System.Drawing.Point(12, 130);
            this.listBoxOutput.Size = new System.Drawing.Size(338, 150);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(362, 300);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.textBoxSeats);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEligible);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.listBoxOutput);
            this.Name = "Form1";
            this.Text = "Автобусний парк";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
