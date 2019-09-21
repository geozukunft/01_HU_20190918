namespace _01_HU_20190918
{
    partial class startmenu
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.cmdBasic = new System.Windows.Forms.Button();
            this.cmdAdvanced = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(588, 101);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // cmdBasic
            // 
            this.cmdBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBasic.Location = new System.Drawing.Point(12, 85);
            this.cmdBasic.Name = "cmdBasic";
            this.cmdBasic.Size = new System.Drawing.Size(336, 85);
            this.cmdBasic.TabIndex = 1;
            this.cmdBasic.Text = "Basic";
            this.cmdBasic.UseVisualStyleBackColor = true;
            this.cmdBasic.Click += new System.EventHandler(this.cmdBasic_Click);
            // 
            // cmdAdvanced
            // 
            this.cmdAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdvanced.Location = new System.Drawing.Point(388, 85);
            this.cmdAdvanced.Name = "cmdAdvanced";
            this.cmdAdvanced.Size = new System.Drawing.Size(336, 85);
            this.cmdAdvanced.TabIndex = 2;
            this.cmdAdvanced.Text = "Advanced";
            this.cmdAdvanced.UseVisualStyleBackColor = true;
            this.cmdAdvanced.Click += new System.EventHandler(this.cmdAdvanced_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(249, 300);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(248, 99);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // startmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdBasic);
            this.Controls.Add(this.cmdAdvanced);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "startmenu";
            this.Text = "startmenu";
            this.Load += new System.EventHandler(this.startmenu_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button cmdBasic;
        private System.Windows.Forms.Button cmdAdvanced;
        private System.Windows.Forms.Button cmdClose;
    }
}