namespace PlanetApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.chkHasRings = new System.Windows.Forms.CheckBox();
            this.txtNumMoons = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDistanceFromSun = new System.Windows.Forms.TextBox();
            this.btnCreatePlanet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Planet Name";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(12, 38);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(200, 20);
            this.txtDiameter.TabIndex = 1;
            this.txtDiameter.Text = "Diameter (km)";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(12, 64);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(200, 20);
            this.txtMass.TabIndex = 2;
            this.txtMass.Text = "Mass (kg)";
            // 
            // chkHasRings
            // 
            this.chkHasRings.AutoSize = true;
            this.chkHasRings.Location = new System.Drawing.Point(12, 90);
            this.chkHasRings.Name = "chkHasRings";
            this.chkHasRings.Size = new System.Drawing.Size(74, 17);
            this.chkHasRings.TabIndex = 3;
            this.chkHasRings.Text = "Has Rings";
            this.chkHasRings.UseVisualStyleBackColor = true;
            // 
            // txtNumMoons
            // 
            this.txtNumMoons.Location = new System.Drawing.Point(12, 113);
            this.txtNumMoons.Name = "txtNumMoons";
            this.txtNumMoons.Size = new System.Drawing.Size(200, 20);
            this.txtNumMoons.TabIndex = 4;
            this.txtNumMoons.Text = "Number of Moons";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(12, 139);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 20);
            this.txtType.TabIndex = 5;
            this.txtType.Text = "Planet Type";
            // 
            // txtDistanceFromSun
            // 
            this.txtDistanceFromSun.Location = new System.Drawing.Point(12, 165);
            this.txtDistanceFromSun.Name = "txtDistanceFromSun";
            this.txtDistanceFromSun.Size = new System.Drawing.Size(200, 20);
            this.txtDistanceFromSun.TabIndex = 6;
            this.txtDistanceFromSun.Text = "Distance from Sun (million km)";
            // 
            // btnCreatePlanet
            // 
            this.btnCreatePlanet.Location = new System.Drawing.Point(12, 191);
            this.btnCreatePlanet.Name = "btnCreatePlanet";
            this.btnCreatePlanet.Size = new System.Drawing.Size(200, 23);
            this.btnCreatePlanet.TabIndex = 7;
            this.btnCreatePlanet.Text = "Create Planet";
            this.btnCreatePlanet.UseVisualStyleBackColor = true;
            this.btnCreatePlanet.Click += new System.EventHandler(this.btnCreatePlanet_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(224, 226);
            this.Controls.Add(this.btnCreatePlanet);
            this.Controls.Add(this.txtDistanceFromSun);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtNumMoons);
            this.Controls.Add(this.chkHasRings);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Planet Creator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.CheckBox chkHasRings;
        private System.Windows.Forms.TextBox txtNumMoons;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDistanceFromSun;
        private System.Windows.Forms.Button btnCreatePlanet;
    }
}
