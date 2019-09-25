namespace _01_HU_20190918
{
    partial class basic
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basic));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.gpoDepartment = new System.Windows.Forms.GroupBox();
            this.rdoCS = new System.Windows.Forms.RadioButton();
            this.rdoMechanicalEng = new System.Windows.Forms.RadioButton();
            this.rdoElectricalEng = new System.Windows.Forms.RadioButton();
            this.rdoMechatronics = new System.Windows.Forms.RadioButton();
            this.lblDataOut = new System.Windows.Forms.Label();
            this.cmdSendData = new System.Windows.Forms.Button();
            this.cmdAbort = new System.Windows.Forms.Button();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            this.gpoDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(253, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Anmelde Formular Litec";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(243, 230);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(249, 40);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.numYear.Location = new System.Drawing.Point(243, 296);
            this.numYear.Margin = new System.Windows.Forms.Padding(2);
            this.numYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(87, 40);
            this.numYear.TabIndex = 5;
            this.numYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.ValueChanged += new System.EventHandler(this.numYear_ValueChanged);
            // 
            // numMonth
            // 
            this.numMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.numMonth.Location = new System.Drawing.Point(333, 296);
            this.numMonth.Margin = new System.Windows.Forms.Padding(2);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(74, 40);
            this.numMonth.TabIndex = 6;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.ValueChanged += new System.EventHandler(this.numMonth_ValueChanged);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBirthdate.Location = new System.Drawing.Point(33, 299);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(208, 33);
            this.lblBirthdate.TabIndex = 8;
            this.lblBirthdate.Text = "Geburtsdatum:";
            this.lblBirthdate.Click += new System.EventHandler(this.lblBirthdate_Click);
            // 
            // gpoDepartment
            // 
            this.gpoDepartment.Controls.Add(this.rdoCS);
            this.gpoDepartment.Controls.Add(this.rdoMechanicalEng);
            this.gpoDepartment.Controls.Add(this.rdoElectricalEng);
            this.gpoDepartment.Controls.Add(this.rdoMechatronics);
            this.gpoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.gpoDepartment.ForeColor = System.Drawing.SystemColors.Window;
            this.gpoDepartment.Location = new System.Drawing.Point(544, 176);
            this.gpoDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.gpoDepartment.Name = "gpoDepartment";
            this.gpoDepartment.Padding = new System.Windows.Forms.Padding(2);
            this.gpoDepartment.Size = new System.Drawing.Size(244, 231);
            this.gpoDepartment.TabIndex = 9;
            this.gpoDepartment.TabStop = false;
            this.gpoDepartment.Text = "Abteilung:";
            this.gpoDepartment.Enter += new System.EventHandler(this.gpoDepartment_Enter);
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
            this.rdoMechanicalEng.CheckedChanged += new System.EventHandler(this.rdoMechanicalEng_CheckedChanged);
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
            this.rdoElectricalEng.CheckedChanged += new System.EventHandler(this.rdoElectricalEng_CheckedChanged);
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
            this.rdoMechatronics.CheckedChanged += new System.EventHandler(this.rdoMechatronics_CheckedChanged);
            // 
            // lblDataOut
            // 
            this.lblDataOut.AutoSize = true;
            this.lblDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOut.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDataOut.Location = new System.Drawing.Point(74, 477);
            this.lblDataOut.Name = "lblDataOut";
            this.lblDataOut.Size = new System.Drawing.Size(0, 37);
            this.lblDataOut.TabIndex = 10;
            // 
            // cmdSendData
            // 
            this.cmdSendData.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdSendData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdSendData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmdSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSendData.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdSendData.Location = new System.Drawing.Point(544, 641);
            this.cmdSendData.Name = "cmdSendData";
            this.cmdSendData.Size = new System.Drawing.Size(169, 48);
            this.cmdSendData.TabIndex = 11;
            this.cmdSendData.Text = "Senden";
            this.cmdSendData.UseVisualStyleBackColor = false;
            this.cmdSendData.Click += new System.EventHandler(this.cmdSendData_Click);
            // 
            // cmdAbort
            // 
            this.cmdAbort.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdAbort.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmdAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbort.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdAbort.Location = new System.Drawing.Point(333, 641);
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.Size = new System.Drawing.Size(204, 48);
            this.cmdAbort.TabIndex = 12;
            this.cmdAbort.Text = "Abbrechen";
            this.cmdAbort.UseVisualStyleBackColor = false;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click);
            // 
            // numDay
            // 
            this.numDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.numDay.Location = new System.Drawing.Point(411, 297);
            this.numDay.Margin = new System.Windows.Forms.Padding(2);
            this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(74, 40);
            this.numDay.TabIndex = 13;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.ValueChanged += new System.EventHandler(this.numDay_ValueChanged);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastname.Location = new System.Drawing.Point(73, 178);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(164, 33);
            this.lblLastname.TabIndex = 14;
            this.lblLastname.Text = "Nachname:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstname.Location = new System.Drawing.Point(96, 232);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(141, 33);
            this.lblFirstname.TabIndex = 15;
            this.lblFirstname.Text = "Vorname:";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(243, 176);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(249, 40);
            this.txtLastname.TabIndex = 16;
            // 
            // basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(838, 759);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.numDay);
            this.Controls.Add(this.cmdAbort);
            this.Controls.Add(this.cmdSendData);
            this.Controls.Add(this.lblDataOut);
            this.Controls.Add(this.gpoDepartment);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "basic";
            this.Text = "Schulanmeldung LITEC Basic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            this.gpoDepartment.ResumeLayout(false);
            this.gpoDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.GroupBox gpoDepartment;
        private System.Windows.Forms.RadioButton rdoElectricalEng;
        private System.Windows.Forms.RadioButton rdoMechatronics;
        private System.Windows.Forms.RadioButton rdoMechanicalEng;
        private System.Windows.Forms.Label lblDataOut;
        private System.Windows.Forms.Button cmdSendData;
        private System.Windows.Forms.Button cmdAbort;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.RadioButton rdoCS;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtLastname;
    }
}

