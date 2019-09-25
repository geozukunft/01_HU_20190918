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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startmenu));
            this.cmdBasic = new System.Windows.Forms.Button();
            this.cmdAdvanced = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // cmdBasic
            // 
            this.cmdBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBasic.Location = new System.Drawing.Point(11, 44);
            this.cmdBasic.Margin = new System.Windows.Forms.Padding(2);
            this.cmdBasic.Name = "cmdBasic";
            this.cmdBasic.Size = new System.Drawing.Size(168, 44);
            this.cmdBasic.TabIndex = 1;
            this.cmdBasic.Text = "Basic";
            this.cmdBasic.UseVisualStyleBackColor = true;
            this.cmdBasic.Click += new System.EventHandler(this.cmdBasic_Click);
            // 
            // cmdAdvanced
            // 
            this.cmdAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdvanced.Location = new System.Drawing.Point(221, 44);
            this.cmdAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAdvanced.Name = "cmdAdvanced";
            this.cmdAdvanced.Size = new System.Drawing.Size(168, 44);
            this.cmdAdvanced.TabIndex = 2;
            this.cmdAdvanced.Text = "Advanced";
            this.cmdAdvanced.UseVisualStyleBackColor = true;
            this.cmdAdvanced.Click += new System.EventHandler(this.cmdAdvanced_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(140, 172);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(2);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(124, 51);
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // startmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdBasic);
            this.Controls.Add(this.cmdAdvanced);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "startmenu";
            this.Text = "startmenu";
            this.Load += new System.EventHandler(this.startmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdBasic;
        private System.Windows.Forms.Button cmdAdvanced;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}