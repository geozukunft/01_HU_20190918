namespace _01_HU_20190918
{
    partial class Advanced
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
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.gpoDepartment = new System.Windows.Forms.GroupBox();
            this.rdoCS = new System.Windows.Forms.RadioButton();
            this.rdoMechanicalEng = new System.Windows.Forms.RadioButton();
            this.rdoElectricalEng = new System.Windows.Forms.RadioButton();
            this.rdoMechatronics = new System.Windows.Forms.RadioButton();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cmdAbort = new System.Windows.Forms.Button();
            this.cmdSendData = new System.Windows.Forms.Button();
            this.pgbSenden = new System.Windows.Forms.ProgressBar();
            this.gpoDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(520, 354);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(496, 73);
            this.txtLastname.TabIndex = 26;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstname.Location = new System.Drawing.Point(220, 479);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(279, 67);
            this.lblFirstname.TabIndex = 25;
            this.lblFirstname.Text = "Vorname:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastname.Location = new System.Drawing.Point(174, 375);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(324, 67);
            this.lblLastname.TabIndex = 24;
            this.lblLastname.Text = "Nachname:";
            // 
            // gpoDepartment
            // 
            this.gpoDepartment.Controls.Add(this.rdoCS);
            this.gpoDepartment.Controls.Add(this.rdoMechanicalEng);
            this.gpoDepartment.Controls.Add(this.rdoElectricalEng);
            this.gpoDepartment.Controls.Add(this.rdoMechatronics);
            this.gpoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.gpoDepartment.ForeColor = System.Drawing.SystemColors.Window;
            this.gpoDepartment.Location = new System.Drawing.Point(1136, 371);
            this.gpoDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpoDepartment.Name = "gpoDepartment";
            this.gpoDepartment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpoDepartment.Size = new System.Drawing.Size(488, 444);
            this.gpoDepartment.TabIndex = 22;
            this.gpoDepartment.TabStop = false;
            this.gpoDepartment.Text = "Abteilung:";
            // 
            // rdoCS
            // 
            this.rdoCS.AutoSize = true;
            this.rdoCS.Location = new System.Drawing.Point(36, 194);
            this.rdoCS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCS.Name = "rdoCS";
            this.rdoCS.Size = new System.Drawing.Size(313, 71);
            this.rdoCS.TabIndex = 4;
            this.rdoCS.TabStop = true;
            this.rdoCS.Text = "Informatik";
            this.rdoCS.UseVisualStyleBackColor = true;
            // 
            // rdoMechanicalEng
            // 
            this.rdoMechanicalEng.AutoSize = true;
            this.rdoMechanicalEng.Location = new System.Drawing.Point(36, 346);
            this.rdoMechanicalEng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMechanicalEng.Name = "rdoMechanicalEng";
            this.rdoMechanicalEng.Size = new System.Drawing.Size(435, 71);
            this.rdoMechanicalEng.TabIndex = 3;
            this.rdoMechanicalEng.TabStop = true;
            this.rdoMechanicalEng.Text = "Maschinenbau";
            this.rdoMechanicalEng.UseVisualStyleBackColor = true;
            // 
            // rdoElectricalEng
            // 
            this.rdoElectricalEng.AutoSize = true;
            this.rdoElectricalEng.Location = new System.Drawing.Point(36, 269);
            this.rdoElectricalEng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoElectricalEng.Name = "rdoElectricalEng";
            this.rdoElectricalEng.Size = new System.Drawing.Size(423, 71);
            this.rdoElectricalEng.TabIndex = 2;
            this.rdoElectricalEng.TabStop = true;
            this.rdoElectricalEng.Text = "Elektrotechnik";
            this.rdoElectricalEng.UseVisualStyleBackColor = true;
            // 
            // rdoMechatronics
            // 
            this.rdoMechatronics.AutoSize = true;
            this.rdoMechatronics.Location = new System.Drawing.Point(36, 115);
            this.rdoMechatronics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMechatronics.Name = "rdoMechatronics";
            this.rdoMechatronics.Size = new System.Drawing.Size(374, 71);
            this.rdoMechatronics.TabIndex = 0;
            this.rdoMechatronics.TabStop = true;
            this.rdoMechatronics.Text = "Mechatronik";
            this.rdoMechatronics.UseVisualStyleBackColor = true;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBirthdate.Location = new System.Drawing.Point(86, 608);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(410, 67);
            this.lblBirthdate.TabIndex = 21;
            this.lblBirthdate.Text = "Geburtsdatum:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(520, 465);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(496, 73);
            this.txtFirstName.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(534, 137);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(639, 67);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Anmelde Formular Litec";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(520, 575);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(402, 80);
            this.dtpBirthdate.TabIndex = 27;
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dtpBirthdate_ValueChanged);
            // 
            // cmdAbort
            // 
            this.cmdAbort.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdAbort.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmdAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbort.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdAbort.Location = new System.Drawing.Point(796, 892);
            this.cmdAbort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(408, 92);
            this.cmdAbort.TabIndex = 29;
            this.cmdAbort.Text = "Abbrechen";
            this.cmdAbort.UseVisualStyleBackColor = false;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click);
            // 
            // cmdSendData
            // 
            this.cmdSendData.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdSendData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdSendData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmdSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSendData.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdSendData.Location = new System.Drawing.Point(1218, 892);
            this.cmdSendData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdSendData.Name = "cmdSendData";
            this.cmdSendData.Size = new System.Drawing.Size(338, 92);
            this.cmdSendData.TabIndex = 28;
            this.cmdSendData.Text = "Senden";
            this.cmdSendData.UseVisualStyleBackColor = false;
            this.cmdSendData.Click += new System.EventHandler(this.cmdSendData_Click);
            // 
            // pgbSenden
            // 
            this.pgbSenden.Location = new System.Drawing.Point(290, 771);
            this.pgbSenden.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pgbSenden.Name = "pgbSenden";
            this.pgbSenden.Size = new System.Drawing.Size(812, 44);
            this.pgbSenden.Step = 1;
            this.pgbSenden.TabIndex = 30;
            this.pgbSenden.Click += new System.EventHandler(this.pgbSenden_Click);
            // 
            // Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1696, 1077);
            this.Controls.Add(this.pgbSenden);
            this.Controls.Add(this.cmdAbort);
            this.Controls.Add(this.cmdSendData);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.gpoDepartment);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Advanced";
            this.Text = "Advanced";
            this.Load += new System.EventHandler(this.Advanced_Load);
            this.gpoDepartment.ResumeLayout(false);
            this.gpoDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.GroupBox gpoDepartment;
        private System.Windows.Forms.RadioButton rdoCS;
        private System.Windows.Forms.RadioButton rdoMechanicalEng;
        private System.Windows.Forms.RadioButton rdoElectricalEng;
        private System.Windows.Forms.RadioButton rdoMechatronics;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Button cmdAbort;
        private System.Windows.Forms.Button cmdSendData;
        private System.Windows.Forms.ProgressBar pgbSenden;
    }
}