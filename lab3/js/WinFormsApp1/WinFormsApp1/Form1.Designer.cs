namespace AtCounter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Label labelResult;

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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxInput
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(360, 20);

            // buttonCount
            this.buttonCount.Location = new System.Drawing.Point(12, 38);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(120, 23);
            this.buttonCount.Text = "Порахувати @";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 70);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 151);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "Лабораторна 3.1 – Підрахунок '@'";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
