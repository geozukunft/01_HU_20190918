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
            this.lblDataOut = new System.Windows.Forms.Label();
            this.gpoDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(260, 184);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(249, 40);
            this.txtLastname.TabIndex = 26;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstname.Location = new System.Drawing.Point(110, 249);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(141, 33);
            this.lblFirstname.TabIndex = 25;
            this.lblFirstname.Text = "Vorname:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastname.Location = new System.Drawing.Point(87, 195);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(164, 33);
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
            this.gpoDepartment.Location = new System.Drawing.Point(568, 193);
            this.gpoDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.gpoDepartment.Name = "gpoDepartment";
            this.gpoDepartment.Padding = new System.Windows.Forms.Padding(2);
            this.gpoDepartment.Size = new System.Drawing.Size(244, 231);
            this.gpoDepartment.TabIndex = 22;
            this.gpoDepartment.TabStop = false;
            this.gpoDepartment.Text = "Abteilung:";
            // 
            // rdoCS
            // 
            this.rdoCS.AutoSize = true;
            this.rdoCS.Location = new System.Drawing.Point(18, 101);
            this.rdoCS.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCS.Name = "rdoCS";
            this.rdoCS.Size = new System.Drawing.Size(162, 37);
            this.rdoCS.TabIndex = 4;
            this.rdoCS.TabStop = true;
            this.rdoCS.Text = "Informatik";
            this.rdoCS.UseVisualStyleBackColor = true;
            // 
            // rdoMechanicalEng
            // 
            this.rdoMechanicalEng.AutoSize = true;
            this.rdoMechanicalEng.Location = new System.Drawing.Point(18, 180);
            this.rdoMechanicalEng.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMechanicalEng.Name = "rdoMechanicalEng";
            this.rdoMechanicalEng.Size = new System.Drawing.Size(222, 37);
            this.rdoMechanicalEng.TabIndex = 3;
            this.rdoMechanicalEng.TabStop = true;
            this.rdoMechanicalEng.Text = "Maschinenbau";
            this.rdoMechanicalEng.UseVisualStyleBackColor = true;
            // 
            // rdoElectricalEng
            // 
            this.rdoElectricalEng.AutoSize = true;
            this.rdoElectricalEng.Location = new System.Drawing.Point(18, 140);
            this.rdoElectricalEng.Margin = new System.Windows.Forms.Padding(2);
            this.rdoElectricalEng.Name = "rdoElectricalEng";
            this.rdoElectricalEng.Size = new System.Drawing.Size(217, 37);
            this.rdoElectricalEng.TabIndex = 2;
            this.rdoElectricalEng.TabStop = true;
            this.rdoElectricalEng.Text = "Elektrotechnik";
            this.rdoElectricalEng.UseVisualStyleBackColor = true;
            // 
            // rdoMechatronics
            // 
            this.rdoMechatronics.AutoSize = true;
            this.rdoMechatronics.Location = new System.Drawing.Point(18, 60);
            this.rdoMechatronics.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMechatronics.Name = "rdoMechatronics";
            this.rdoMechatronics.Size = new System.Drawing.Size(192, 37);
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
            this.lblBirthdate.Location = new System.Drawing.Point(43, 316);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(208, 33);
            this.lblBirthdate.TabIndex = 21;
            this.lblBirthdate.Text = "Geburtsdatum:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(260, 242);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(249, 40);
            this.txtFirstName.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(267, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 33);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Anmelde Formular Litec";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(260, 299);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(203, 44);
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
            this.cmdAbort.Location = new System.Drawing.Point(398, 464);
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(204, 48);
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
            this.cmdSendData.Location = new System.Drawing.Point(609, 464);
            this.cmdSendData.Name = "cmdSendData";
            this.cmdSendData.Size = new System.Drawing.Size(169, 48);
            this.cmdSendData.TabIndex = 28;
            this.cmdSendData.Text = "Senden";
            this.cmdSendData.UseVisualStyleBackColor = false;
            this.cmdSendData.Click += new System.EventHandler(this.cmdSendData_Click);
            // 
            // lblDataOut
            // 
            this.lblDataOut.AutoSize = true;
            this.lblDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOut.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDataOut.Location = new System.Drawing.Point(42, 398);
            this.lblDataOut.Name = "lblDataOut";
            this.lblDataOut.Size = new System.Drawing.Size(0, 37);
            this.lblDataOut.TabIndex = 30;
            this.lblDataOut.Click += new System.EventHandler(this.lblDataOut_Click);
            // 
            // Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(848, 560);
            this.Controls.Add(this.lblDataOut);
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
        private System.Windows.Forms.Label lblDataOut;
    }
}