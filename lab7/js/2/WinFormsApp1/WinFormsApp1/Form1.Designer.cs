namespace Lab7_ZNAK
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxZodiac;
        private System.Windows.Forms.TextBox textBoxBDay;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxZodiac = new System.Windows.Forms.TextBox();
            this.textBoxBDay = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            
            // textBoxName
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.PlaceholderText = "Прізвище, ім'я";

            // textBoxZodiac
            this.textBoxZodiac.Location = new System.Drawing.Point(12, 40);
            this.textBoxZodiac.PlaceholderText = "Знак Зодіаку";

            // textBoxBDay
            this.textBoxBDay.Location = new System.Drawing.Point(12, 68);
            this.textBoxBDay.PlaceholderText = "Дата нар. (ДД.ММ.РРРР)";

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(12, 96);
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // buttonSort
            this.buttonSort.Location = new System.Drawing.Point(100, 96);
            this.buttonSort.Text = "Сортувати";
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);

            // textBoxSearch
            this.textBoxSearch.Location = new System.Drawing.Point(12, 130);
            this.textBoxSearch.PlaceholderText = "Пошук за прізвищем";

            // buttonFind
            this.buttonFind.Location = new System.Drawing.Point(200, 130);
            this.buttonFind.Text = "Знайти";
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);

            // listBoxData
            this.listBoxData.Location = new System.Drawing.Point(12, 160);
            this.listBoxData.Size = new System.Drawing.Size(360, 180);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxZodiac);
            this.Controls.Add(this.textBoxBDay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.listBoxData);
            this.Text = "Реєстр знаків Зодіаку";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
