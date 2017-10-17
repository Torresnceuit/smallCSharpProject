namespace Csharp_Project
{
    partial class FORM_HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_HOME));
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.BackgroundImage = global::Csharp_Project.Properties.Resources.Settings_canvas;
            resources.ApplyResources(this.panelSettings, "panelSettings");
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Click += new System.EventHandler(this.panelSettings_Click);
            this.panelSettings.MouseLeave += new System.EventHandler(this.panelSettings_MouseLeave);
            this.panelSettings.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.Transparent;
            this.panelUsers.BackgroundImage = global::Csharp_Project.Properties.Resources.Users_canvas;
            resources.ApplyResources(this.panelUsers, "panelUsers");
            this.panelUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Click += new System.EventHandler(this.panelUsers_Click);
            this.panelUsers.MouseLeave += new System.EventHandler(this.panelUsers_MouseLeave);
            this.panelUsers.MouseHover += new System.EventHandler(this.panelUsers_MouseHover);
            // 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.Transparent;
            this.panelOrders.BackgroundImage = global::Csharp_Project.Properties.Resources.Orders_canvas;
            resources.ApplyResources(this.panelOrders, "panelOrders");
            this.panelOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Click += new System.EventHandler(this.panelOrders_Click);
            this.panelOrders.MouseLeave += new System.EventHandler(this.panelOrders_MouseLeave);
            this.panelOrders.MouseHover += new System.EventHandler(this.panelOrders_MouseHover);
            // 
            // panelCustomers
            // 
            this.panelCustomers.BackColor = System.Drawing.Color.Transparent;
            this.panelCustomers.BackgroundImage = global::Csharp_Project.Properties.Resources.Customers_canvas;
            resources.ApplyResources(this.panelCustomers, "panelCustomers");
            this.panelCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Click += new System.EventHandler(this.panelCustomers_Click);
            this.panelCustomers.MouseLeave += new System.EventHandler(this.panelCustomers_MouseLeave);
            this.panelCustomers.MouseHover += new System.EventHandler(this.panelCustomers_MouseHover);
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.Transparent;
            this.panelCategory.BackgroundImage = global::Csharp_Project.Properties.Resources.Categories_canvas;
            resources.ApplyResources(this.panelCategory, "panelCategory");
            this.panelCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Click += new System.EventHandler(this.panelCategory_Click);
            this.panelCategory.MouseLeave += new System.EventHandler(this.panelCategory_MouseLeave);
            this.panelCategory.MouseHover += new System.EventHandler(this.panelCategory_MouseHover);
            // 
            // panelProduct
            // 
            this.panelProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelProduct.BackColor = System.Drawing.Color.Transparent;
            this.panelProduct.BackgroundImage = global::Csharp_Project.Properties.Resources.Product_canvas;
            resources.ApplyResources(this.panelProduct, "panelProduct");
            this.panelProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.TabStop = true;
            this.panelProduct.Click += new System.EventHandler(this.panelProduct_Click);
            this.panelProduct.MouseLeave += new System.EventHandler(this.panelProduct_MouseLeave);
            this.panelProduct.MouseHover += new System.EventHandler(this.panelProduct_MouseHover);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Name = "lblUser";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Name = "lblTime";
            // 
            // FORM_HOME
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.panelCustomers);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.panelProduct);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_HOME";
            this.Load += new System.EventHandler(this.FORM_HOME_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
    }
}