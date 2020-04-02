namespace frontend
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.From = new System.Windows.Forms.Label();
            this.FromLocation = new System.Windows.Forms.ComboBox();
            this.To = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Travellers = new System.Windows.Forms.Label();
            this.NumTravellers = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Find = new System.Windows.Forms.Button();
            this.ViewTrips = new System.Windows.Forms.LinkLabel();
            this.Profile = new System.Windows.Forms.LinkLabel();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1013, 592);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.LightGray;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.Location = new System.Drawing.Point(8, 102);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(217, 126);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(9, 7);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(742, 79);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.BackColor = System.Drawing.Color.LightGray;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(19, 48);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(57, 25);
            this.From.TabIndex = 1;
            this.From.Text = "From";
            // 
            // FromLocation
            // 
            this.FromLocation.FormattingEnabled = true;
            this.FromLocation.Items.AddRange(new object[] {
            "Location1",
            "Location2",
            "Location3",
            "Location4"});
            this.FromLocation.Location = new System.Drawing.Point(80, 48);
            this.FromLocation.Name = "FromLocation";
            this.FromLocation.Size = new System.Drawing.Size(121, 24);
            this.FromLocation.TabIndex = 2;
            this.FromLocation.SelectedIndexChanged += new System.EventHandler(this.FromLocation_SelectedIndexChanged);
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.BackColor = System.Drawing.Color.LightGray;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(232, 48);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(36, 25);
            this.To.TabIndex = 3;
            this.To.Text = "To";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Location1",
            "Location2",
            "Location3",
            "Location4"});
            this.comboBox1.Location = new System.Drawing.Point(272, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Travellers
            // 
            this.Travellers.AutoSize = true;
            this.Travellers.BackColor = System.Drawing.Color.LightGray;
            this.Travellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Travellers.Location = new System.Drawing.Point(421, 48);
            this.Travellers.Name = "Travellers";
            this.Travellers.Size = new System.Drawing.Size(98, 25);
            this.Travellers.TabIndex = 5;
            this.Travellers.Text = "Travellers";
            // 
            // NumTravellers
            // 
            this.NumTravellers.FormattingEnabled = true;
            this.NumTravellers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.NumTravellers.Location = new System.Drawing.Point(525, 47);
            this.NumTravellers.Name = "NumTravellers";
            this.NumTravellers.Size = new System.Drawing.Size(121, 24);
            this.NumTravellers.TabIndex = 6;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.LightGray;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(669, 48);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(53, 25);
            this.Date.TabIndex = 7;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(730, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Find
            // 
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Find.Location = new System.Drawing.Point(915, 49);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 9;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            // 
            // ViewTrips
            // 
            this.ViewTrips.AutoSize = true;
            this.ViewTrips.BackColor = System.Drawing.Color.LightGray;
            this.ViewTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTrips.LinkColor = System.Drawing.SystemColors.ControlText;
            this.ViewTrips.Location = new System.Drawing.Point(86, 145);
            this.ViewTrips.Name = "ViewTrips";
            this.ViewTrips.Size = new System.Drawing.Size(135, 25);
            this.ViewTrips.TabIndex = 10;
            this.ViewTrips.TabStop = true;
            this.ViewTrips.Text = "View my Trips";
            this.ViewTrips.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewTrips_LinkClicked);
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.BackColor = System.Drawing.Color.LightGray;
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.LinkColor = System.Drawing.SystemColors.ControlText;
            this.Profile.Location = new System.Drawing.Point(86, 187);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(66, 25);
            this.Profile.TabIndex = 11;
            this.Profile.TabStop = true;
            this.Profile.Text = "Profile";
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.LightGray;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.SystemColors.ControlText;
            this.Logout.Location = new System.Drawing.Point(86, 231);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(72, 25);
            this.Logout.TabIndex = 12;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frontend.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 592);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.ViewTrips);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.NumTravellers);
            this.Controls.Add(this.Travellers);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.FromLocation);
            this.Controls.Add(this.From);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.ComboBox FromLocation;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Travellers;
        private System.Windows.Forms.ComboBox NumTravellers;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Find;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.LinkLabel ViewTrips;
        private System.Windows.Forms.LinkLabel Profile;
        private System.Windows.Forms.LinkLabel Logout;
    }
}