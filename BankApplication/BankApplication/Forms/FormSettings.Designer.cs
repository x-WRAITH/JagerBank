﻿
namespace BankApplication.Forms
{
    partial class FormSettings
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
            this.config_control2 = new config_library.config_control();
            this.SuspendLayout();
            // 
            // config_control2
            // 
            this.config_control2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.config_control2.Location = new System.Drawing.Point(1, 0);
            this.config_control2.Name = "config_control2";
            this.config_control2.Size = new System.Drawing.Size(799, 450);
            this.config_control2.TabIndex = 0;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.config_control2);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private config_library.config_control config_control1;
        private config_library.config_control config_control2;
    }
}