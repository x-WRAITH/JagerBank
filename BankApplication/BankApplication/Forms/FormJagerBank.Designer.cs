
namespace BankApplication.Forms
{
    partial class FormJagerBank
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleAdminInfo = new System.Windows.Forms.Label();
            this.labelDisAdminInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.iconPictureBox1.BackgroundImage = global::BankApplication.Properties.Resources.logo;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 74;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(800, 74);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelTitleAdminInfo
            // 
            this.labelTitleAdminInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleAdminInfo.AutoSize = true;
            this.labelTitleAdminInfo.Font = new System.Drawing.Font("Segoe UI Historic", 15F);
            this.labelTitleAdminInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleAdminInfo.Location = new System.Drawing.Point(143, 135);
            this.labelTitleAdminInfo.Name = "labelTitleAdminInfo";
            this.labelTitleAdminInfo.Size = new System.Drawing.Size(102, 28);
            this.labelTitleAdminInfo.TabIndex = 4;
            this.labelTitleAdminInfo.Text = "Witaj, Test";
            // 
            // labelDisAdminInfo
            // 
            this.labelDisAdminInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDisAdminInfo.AutoSize = true;
            this.labelDisAdminInfo.Font = new System.Drawing.Font("Segoe UI Historic", 15F);
            this.labelDisAdminInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDisAdminInfo.Location = new System.Drawing.Point(143, 192);
            this.labelDisAdminInfo.Name = "labelDisAdminInfo";
            this.labelDisAdminInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDisAdminInfo.Size = new System.Drawing.Size(594, 28);
            this.labelDisAdminInfo.TabIndex = 5;
            this.labelDisAdminInfo.Text = "sdfgsdfgsdfgggggggggggggggggggggggggggggggggggggggg";
            this.labelDisAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormJagerBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDisAdminInfo);
            this.Controls.Add(this.labelTitleAdminInfo);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "FormJagerBank";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.FormJagerBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelTitleAdminInfo;
        private System.Windows.Forms.Label labelDisAdminInfo;
    }
}