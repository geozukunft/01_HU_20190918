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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.gpoDepartment = new System.Windows.Forms.GroupBox();
            this.rdoMechatronics = new System.Windows.Forms.RadioButton();
            this.rdoCS = new System.Windows.Forms.RadioButton();
            this.rdoElectricalEng = new System.Windows.Forms.RadioButton();
            this.rdoMechanicalEng = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gpoDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastName.Location = new System.Drawing.Point(141, 456);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(324, 67);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Nachname:";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(64, 339);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(639, 67);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Anmelde Formular Litec";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Location = new System.Drawing.Point(186, 559);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(279, 67);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Vorname:";
            this.lblFirstName.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(477, 454);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(496, 73);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(477, 557);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(496, 73);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.numYear.Location = new System.Drawing.Point(477, 685);
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
            this.numYear.Size = new System.Drawing.Size(174, 73);
            this.numYear.TabIndex = 5;
            this.numYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numMonth
            // 
            this.numMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.numMonth.Location = new System.Drawing.Point(657, 685);
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
            this.numMonth.Size = new System.Drawing.Size(148, 73);
            this.numMonth.TabIndex = 6;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.ValueChanged += new System.EventHandler(this.numMonth_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.numericUpDown1.Location = new System.Drawing.Point(811, 685);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 73);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBirthdate.Location = new System.Drawing.Point(55, 691);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(410, 67);
            this.lblBirthdate.TabIndex = 8;
            this.lblBirthdate.Text = "Geburtsdatum:";
            // 
            // gpoDepartment
            // 
            this.gpoDepartment.Controls.Add(this.rdoMechanicalEng);
            this.gpoDepartment.Controls.Add(this.rdoElectricalEng);
            this.gpoDepartment.Controls.Add(this.rdoCS);
            this.gpoDepartment.Controls.Add(this.rdoMechatronics);
            this.gpoDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.gpoDepartment.ForeColor = System.Drawing.SystemColors.Window;
            this.gpoDepartment.Location = new System.Drawing.Point(1072, 454);
            this.gpoDepartment.Name = "gpoDepartment";
            this.gpoDepartment.Size = new System.Drawing.Size(473, 444);
            this.gpoDepartment.TabIndex = 9;
            this.gpoDepartment.TabStop = false;
            this.gpoDepartment.Text = "Abteilung:";
            this.gpoDepartment.Enter += new System.EventHandler(this.gpoDepartment_Enter);
            // 
            // rdoMechatronics
            // 
            this.rdoMechatronics.AutoSize = true;
            this.rdoMechatronics.Location = new System.Drawing.Point(35, 115);
            this.rdoMechatronics.Name = "rdoMechatronics";
            this.rdoMechatronics.Size = new System.Drawing.Size(374, 71);
            this.rdoMechatronics.TabIndex = 0;
            this.rdoMechatronics.TabStop = true;
            this.rdoMechatronics.Text = "Mechatronik";
            this.rdoMechatronics.UseVisualStyleBackColor = true;
            // 
            // rdoCS
            // 
            this.rdoCS.AutoSize = true;
            this.rdoCS.Location = new System.Drawing.Point(35, 192);
            this.rdoCS.Name = "rdoCS";
            this.rdoCS.Size = new System.Drawing.Size(313, 71);
            this.rdoCS.TabIndex = 1;
            this.rdoCS.TabStop = true;
            this.rdoCS.Text = "Informatik";
            this.rdoCS.UseVisualStyleBackColor = true;
            this.rdoCS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoElectricalEng
            // 
            this.rdoElectricalEng.AutoSize = true;
            this.rdoElectricalEng.Location = new System.Drawing.Point(35, 269);
            this.rdoElectricalEng.Name = "rdoElectricalEng";
            this.rdoElectricalEng.Size = new System.Drawing.Size(423, 71);
            this.rdoElectricalEng.TabIndex = 2;
            this.rdoElectricalEng.TabStop = true;
            this.rdoElectricalEng.Text = "Elektrotechnik";
            this.rdoElectricalEng.UseVisualStyleBackColor = true;
            // 
            // rdoMechanicalEng
            // 
            this.rdoMechanicalEng.AutoSize = true;
            this.rdoMechanicalEng.Location = new System.Drawing.Point(35, 346);
            this.rdoMechanicalEng.Name = "rdoMechanicalEng";
            this.rdoMechanicalEng.Size = new System.Drawing.Size(435, 71);
            this.rdoMechanicalEng.TabIndex = 3;
            this.rdoMechanicalEng.TabStop = true;
            this.rdoMechanicalEng.Text = "Maschinenbau";
            this.rdoMechanicalEng.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1675, 1220);
            this.Controls.Add(this.gpoDepartment);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLastName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Schulanmeldung LITEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gpoDepartment.ResumeLayout(false);
            this.gpoDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.GroupBox gpoDepartment;
        private System.Windows.Forms.RadioButton rdoElectricalEng;
        private System.Windows.Forms.RadioButton rdoCS;
        private System.Windows.Forms.RadioButton rdoMechatronics;
        private System.Windows.Forms.RadioButton rdoMechanicalEng;
    }
}

