namespace ClinicApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName, textBoxNumber, textBoxDoctor, textBoxDay, textBoxStart, textBoxEnd;
        private System.Windows.Forms.Button buttonAdd, buttonShowAll, buttonCheckF, buttonFridayDoctors, buttonLateTherapist, buttonTomorrowStaff;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.TextBox textBoxQueryDay, textBoxQueryTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            
            
            
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxDoctor = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxQueryDay = new System.Windows.Forms.TextBox();
            this.textBoxQueryTime = new System.Windows.Forms.TextBox();

            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonCheckF = new System.Windows.Forms.Button();
            this.buttonFridayDoctors = new System.Windows.Forms.Button();
            this.buttonLateTherapist = new System.Windows.Forms.Button();
            this.buttonTomorrowStaff = new System.Windows.Forms.Button();

            this.listBoxOutput = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            // --- TextBoxes ---
            this.textBoxName.Location = new System.Drawing.Point(20, 20);
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.PlaceholderText = "Назва кабінету";

            this.textBoxNumber.Location = new System.Drawing.Point(20, 50);
            this.textBoxNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumber.PlaceholderText = "Номер кабінету";

            this.textBoxDoctor.Location = new System.Drawing.Point(20, 80);
            this.textBoxDoctor.Size = new System.Drawing.Size(200, 20);
            this.textBoxDoctor.PlaceholderText = "ПІБ лікаря";

            this.textBoxDay.Location = new System.Drawing.Point(20, 110);
            this.textBoxDay.Size = new System.Drawing.Size(200, 20);
            this.textBoxDay.PlaceholderText = "День прийому (1-7)";

            this.textBoxStart.Location = new System.Drawing.Point(20, 140);
            this.textBoxStart.Size = new System.Drawing.Size(200, 20);
            this.textBoxStart.PlaceholderText = "Час початку (ГГ:ХХ:СС)";

            this.textBoxEnd.Location = new System.Drawing.Point(20, 170);
            this.textBoxEnd.Size = new System.Drawing.Size(200, 20);
            this.textBoxEnd.PlaceholderText = "Час кінця (ГГ:ХХ:СС)";

            this.textBoxQueryDay.Location = new System.Drawing.Point(20, 210);
            this.textBoxQueryDay.Size = new System.Drawing.Size(95, 20);
            this.textBoxQueryDay.PlaceholderText = "День (1-7)";

            this.textBoxQueryTime.Location = new System.Drawing.Point(125, 210);
            this.textBoxQueryTime.Size = new System.Drawing.Size(95, 20);
            this.textBoxQueryTime.PlaceholderText = "Час (ГГ:ХХ:СС)";

            // --- Buttons ---
            this.buttonAdd.Location = new System.Drawing.Point(240, 20);
            this.buttonAdd.Size = new System.Drawing.Size(160, 30);
            this.buttonAdd.Text = "Додати запис";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            this.buttonShowAll.Location = new System.Drawing.Point(240, 60);
            this.buttonShowAll.Size = new System.Drawing.Size(160, 30);
            this.buttonShowAll.Text = "Показати всі";
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);

            this.buttonCheckF.Location = new System.Drawing.Point(240, 100);
            this.buttonCheckF.Size = new System.Drawing.Size(160, 30);
            this.buttonCheckF.Text = "Чи працює флюорографія";
            this.buttonCheckF.Click += new System.EventHandler(this.buttonCheckF_Click);

            this.buttonFridayDoctors.Location = new System.Drawing.Point(240, 140);
            this.buttonFridayDoctors.Size = new System.Drawing.Size(160, 30);
            this.buttonFridayDoctors.Text = "П’ятниця після 12:00";
            this.buttonFridayDoctors.Click += new System.EventHandler(this.buttonFridayDoctors_Click);

            this.buttonLateTherapist.Location = new System.Drawing.Point(240, 180);
            this.buttonLateTherapist.Size = new System.Drawing.Size(160, 30);
            this.buttonLateTherapist.Text = "Пізній терапевт";
            this.buttonLateTherapist.Click += new System.EventHandler(this.buttonLateTherapist_Click);

            this.buttonTomorrowStaff.Location = new System.Drawing.Point(240, 220);
            this.buttonTomorrowStaff.Size = new System.Drawing.Size(160, 30);
            this.buttonTomorrowStaff.Text = "Завтра: зранку > вечір";
            this.buttonTomorrowStaff.Click += new System.EventHandler(this.buttonTomorrowStaff_Click);

            // --- ListBox ---
            this.listBoxOutput.Location = new System.Drawing.Point(20, 260);
            this.listBoxOutput.Size = new System.Drawing.Size(380, 280);

            // --- Add to Controls ---
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                textBoxName, textBoxNumber, textBoxDoctor, textBoxDay, textBoxStart, textBoxEnd,
                textBoxQueryDay, textBoxQueryTime,
                buttonAdd, buttonShowAll, buttonCheckF, buttonFridayDoctors, buttonLateTherapist, buttonTomorrowStaff,
                listBoxOutput
            });

            this.ClientSize = new System.Drawing.Size(430, 560);
            this.Name = "Form1";
            this.Text = "Поліклініка";
            this.ResumeLayout(false);
            this.PerformLayout();
            
            buttonDemo_Click(null, null);
            
        }
    }
}
