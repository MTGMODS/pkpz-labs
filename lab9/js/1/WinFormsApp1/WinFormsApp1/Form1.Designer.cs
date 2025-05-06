namespace Lab9_List
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox textBoxBefore;
        private System.Windows.Forms.TextBox textBoxAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxElement;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProcess = new System.Windows.Forms.Button();
            this.textBoxBefore = new System.Windows.Forms.TextBox();
            this.textBoxAfter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxElement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(200, 20);
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.Text = "Обробити";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);

            // 
            // textBoxElement
            // 
            this.textBoxElement.Location = new System.Drawing.Point(90, 20);
            this.textBoxElement.Size = new System.Drawing.Size(100, 20);

            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.Text = "Елемент E:";

            // 
            // textBoxBefore
            // 
            this.textBoxBefore.Location = new System.Drawing.Point(15, 60);
            this.textBoxBefore.Multiline = true;
            this.textBoxBefore.Size = new System.Drawing.Size(380, 50);
            this.textBoxBefore.ScrollBars = ScrollBars.Vertical;

            // 
            // textBoxAfter
            // 
            this.textBoxAfter.Location = new System.Drawing.Point(15, 140);
            this.textBoxAfter.Multiline = true;
            this.textBoxAfter.Size = new System.Drawing.Size(380, 50);
            this.textBoxAfter.ScrollBars = ScrollBars.Vertical;

            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.Text = "Модифікований список:";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(410, 210);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.textBoxElement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAfter);
            this.Text = "Обробка списку";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
