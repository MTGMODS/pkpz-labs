namespace ZodiacQuiz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.Text = "Введіть знак зодіаку (укр):";

            this.textBox1.Location = new System.Drawing.Point(20, 45);
            this.textBox1.Size = new System.Drawing.Size(200, 23);

            this.buttonCheck.Location = new System.Drawing.Point(20, 80);
            this.buttonCheck.Size = new System.Drawing.Size(100, 30);
            this.buttonCheck.Text = "Перевірити";
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);

            this.buttonExit.Location = new System.Drawing.Point(130, 80);
            this.buttonExit.Size = new System.Drawing.Size(90, 30);
            this.buttonExit.Text = "Вийти";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);

            this.richTextBoxOutput.Location = new System.Drawing.Point(20, 130);
            this.richTextBoxOutput.Size = new System.Drawing.Size(350, 120);

            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.richTextBoxOutput);
            this.Text = "Вікторина — Знаки Зодіаку";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}