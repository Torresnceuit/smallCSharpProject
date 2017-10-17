namespace Csharp_Project
{
    partial class FORM_SETTINGS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SETTINGS));
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnChangeBackground = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(46, 28);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(199, 45);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            this.btnChangePass.MouseLeave += new System.EventHandler(this.btnChangePass_MouseLeave);
            this.btnChangePass.MouseHover += new System.EventHandler(this.btnChangePass_MouseHover);
            // 
            // btnChangeBackground
            // 
            this.btnChangeBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBackground.ForeColor = System.Drawing.Color.White;
            this.btnChangeBackground.Location = new System.Drawing.Point(47, 79);
            this.btnChangeBackground.Name = "btnChangeBackground";
            this.btnChangeBackground.Size = new System.Drawing.Size(198, 45);
            this.btnChangeBackground.TabIndex = 1;
            this.btnChangeBackground.Text = "Change Background Color";
            this.btnChangeBackground.UseVisualStyleBackColor = false;
            this.btnChangeBackground.Click += new System.EventHandler(this.btnChangeBackground_Click);
            this.btnChangeBackground.MouseLeave += new System.EventHandler(this.btnChangeBackground_MouseLeave);
            this.btnChangeBackground.MouseHover += new System.EventHandler(this.btnChangeBackground_MouseHover);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.ForeColor = System.Drawing.Color.White;
            this.btnChangeImage.Location = new System.Drawing.Point(47, 130);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(198, 45);
            this.btnChangeImage.TabIndex = 2;
            this.btnChangeImage.Text = "Change Background Image";
            this.btnChangeImage.UseVisualStyleBackColor = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            this.btnChangeImage.MouseLeave += new System.EventHandler(this.btnChangeImage_MouseLeave);
            this.btnChangeImage.MouseHover += new System.EventHandler(this.btnChangeImage_MouseHover);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(281, 79);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 45);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset default settings";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FORM_SETTINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(426, 216);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.btnChangeBackground);
            this.Controls.Add(this.btnChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_SETTINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORM_SETTINGS_FormClosed);
            this.Load += new System.EventHandler(this.FORM_SETTINGS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnChangeBackground;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnReset;
    }
}