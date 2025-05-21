namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(400, 30);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Вибрати файл та розпізнати числа";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            this.txtInput.Location = new System.Drawing.Point(12, 50);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(460, 100);
            this.txtInput.TabIndex = 1;

            this.lstResults.FormattingEnabled = true;
            this.lstResults.HorizontalScrollbar = true;
            this.lstResults.Location = new System.Drawing.Point(12, 160);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(460, 180);
            this.lstResults.TabIndex = 2;
    
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Lab12 - Number Recognizer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
