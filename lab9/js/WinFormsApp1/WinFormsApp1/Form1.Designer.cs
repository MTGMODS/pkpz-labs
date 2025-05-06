namespace Lab9_Stack
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnCheck;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.textBoxResult.Location = new System.Drawing.Point(12, 12);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(260, 150);

            this.btnCheck.Location = new System.Drawing.Point(12, 175);
            this.btnCheck.Size = new System.Drawing.Size(100, 23);
            this.btnCheck.Text = "Check Brackets";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);

            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.btnCheck);
            this.Text = "Bracket Checker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}