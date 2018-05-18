namespace SchoolSports
{
    partial class AthleteRegistration
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
            this.groupBoxAthlete = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxStudenFirstName = new System.Windows.Forms.TextBox();
            this.txtBxStudentLastName = new System.Windows.Forms.TextBox();
            this.txtBxSportType = new System.Windows.Forms.TextBox();
            this.btnSubmitAthlete = new System.Windows.Forms.Button();
            this.lblErrorAthlete = new System.Windows.Forms.Label();
            this.groupBoxAthlete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAthlete
            // 
            this.groupBoxAthlete.Controls.Add(this.label7);
            this.groupBoxAthlete.Controls.Add(this.label8);
            this.groupBoxAthlete.Controls.Add(this.label9);
            this.groupBoxAthlete.Controls.Add(this.txtBxStudenFirstName);
            this.groupBoxAthlete.Controls.Add(this.txtBxStudentLastName);
            this.groupBoxAthlete.Controls.Add(this.txtBxSportType);
            this.groupBoxAthlete.Location = new System.Drawing.Point(15, 25);
            this.groupBoxAthlete.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAthlete.Name = "groupBoxAthlete";
            this.groupBoxAthlete.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAthlete.Size = new System.Drawing.Size(351, 220);
            this.groupBoxAthlete.TabIndex = 1;
            this.groupBoxAthlete.TabStop = false;
            this.groupBoxAthlete.Text = "Athlete Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Student First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Student Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sport Type";
            // 
            // txtBxStudenFirstName
            // 
            this.txtBxStudenFirstName.Location = new System.Drawing.Point(172, 36);
            this.txtBxStudenFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxStudenFirstName.Name = "txtBxStudenFirstName";
            this.txtBxStudenFirstName.Size = new System.Drawing.Size(132, 21);
            this.txtBxStudenFirstName.TabIndex = 16;
            // 
            // txtBxStudentLastName
            // 
            this.txtBxStudentLastName.Location = new System.Drawing.Point(172, 82);
            this.txtBxStudentLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxStudentLastName.Name = "txtBxStudentLastName";
            this.txtBxStudentLastName.Size = new System.Drawing.Size(132, 21);
            this.txtBxStudentLastName.TabIndex = 17;
            // 
            // txtBxSportType
            // 
            this.txtBxSportType.Location = new System.Drawing.Point(172, 134);
            this.txtBxSportType.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSportType.Name = "txtBxSportType";
            this.txtBxSportType.Size = new System.Drawing.Size(132, 21);
            this.txtBxSportType.TabIndex = 18;
            // 
            // btnSubmitAthlete
            // 
            this.btnSubmitAthlete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmitAthlete.Location = new System.Drawing.Point(197, 272);
            this.btnSubmitAthlete.Name = "btnSubmitAthlete";
            this.btnSubmitAthlete.Size = new System.Drawing.Size(86, 27);
            this.btnSubmitAthlete.TabIndex = 20;
            this.btnSubmitAthlete.Text = "Submit";
            this.btnSubmitAthlete.UseVisualStyleBackColor = false;
            this.btnSubmitAthlete.Click += new System.EventHandler(this.btnSubmitAthlete_Click);
            // 
            // lblErrorAthlete
            // 
            this.lblErrorAthlete.AutoSize = true;
            this.lblErrorAthlete.Location = new System.Drawing.Point(12, 257);
            this.lblErrorAthlete.Name = "lblErrorAthlete";
            this.lblErrorAthlete.Size = new System.Drawing.Size(0, 15);
            this.lblErrorAthlete.TabIndex = 20;
            // 
            // AthleteRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(415, 326);
            this.Controls.Add(this.lblErrorAthlete);
            this.Controls.Add(this.btnSubmitAthlete);
            this.Controls.Add(this.groupBoxAthlete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AthleteRegistration";
            this.Text = "AthleteRegistration";
            this.groupBoxAthlete.ResumeLayout(false);
            this.groupBoxAthlete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAthlete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxStudenFirstName;
        private System.Windows.Forms.TextBox txtBxStudentLastName;
        private System.Windows.Forms.TextBox txtBxSportType;
        private System.Windows.Forms.Button btnSubmitAthlete;
        private System.Windows.Forms.Label lblErrorAthlete;
    }
}