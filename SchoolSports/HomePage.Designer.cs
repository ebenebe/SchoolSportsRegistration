namespace SchoolSports
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTeam = new System.Windows.Forms.Button();
            this.btnAthlete = new System.Windows.Forms.Button();
            this.groupBoxTeam = new System.Windows.Forms.GroupBox();
            this.groupBoxAthlete = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBoxTeam.SuspendLayout();
            this.groupBoxAthlete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO SCHOOL SPORTS ARENA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTeam
            // 
            this.btnTeam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.Location = new System.Drawing.Point(58, 61);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(158, 38);
            this.btnTeam.TabIndex = 3;
            this.btnTeam.Text = "CLICK TO REGISTER";
            this.btnTeam.UseVisualStyleBackColor = false;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // btnAthlete
            // 
            this.btnAthlete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAthlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAthlete.Location = new System.Drawing.Point(58, 36);
            this.btnAthlete.Name = "btnAthlete";
            this.btnAthlete.Size = new System.Drawing.Size(158, 34);
            this.btnAthlete.TabIndex = 4;
            this.btnAthlete.Text = "CLICK TO REGISTER";
            this.btnAthlete.UseVisualStyleBackColor = false;
            this.btnAthlete.Click += new System.EventHandler(this.btnAthlete_Click);
            // 
            // groupBoxTeam
            // 
            this.groupBoxTeam.Controls.Add(this.btnTeam);
            this.groupBoxTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTeam.Location = new System.Drawing.Point(225, 66);
            this.groupBoxTeam.Name = "groupBoxTeam";
            this.groupBoxTeam.Size = new System.Drawing.Size(351, 115);
            this.groupBoxTeam.TabIndex = 5;
            this.groupBoxTeam.TabStop = false;
            this.groupBoxTeam.Text = "Team Registration";
            // 
            // groupBoxAthlete
            // 
            this.groupBoxAthlete.Controls.Add(this.btnAthlete);
            this.groupBoxAthlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAthlete.Location = new System.Drawing.Point(225, 204);
            this.groupBoxAthlete.Name = "groupBoxAthlete";
            this.groupBoxAthlete.Size = new System.Drawing.Size(351, 105);
            this.groupBoxAthlete.TabIndex = 0;
            this.groupBoxAthlete.TabStop = false;
            this.groupBoxAthlete.Text = "Athlete Registration";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(283, 357);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(158, 36);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display Sports Info";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 470);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBoxAthlete);
            this.Controls.Add(this.groupBoxTeam);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "HomePage";
            this.Text = "School Sports - HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBoxTeam.ResumeLayout(false);
            this.groupBoxAthlete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Button btnAthlete;
        private System.Windows.Forms.GroupBox groupBoxTeam;
        private System.Windows.Forms.GroupBox groupBoxAthlete;
        private System.Windows.Forms.Button btnDisplay;
    }
}

