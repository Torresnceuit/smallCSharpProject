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
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.Transparent;
            this.panelUsers.BackgroundImage = global::Csharp_Project.Properties.Resources.Users_canvas;
            resources.ApplyResources(this.panelUsers, "panelUsers");
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Click += new System.EventHandler(this.panelUsers_Click);
            this.panelUsers.MouseLeave += new System.EventHandler(this.panelUsers_MouseLeave);
            this.panelUsers.MouseHover += new System.EventHandler(this.panelUsers_MouseHover);
            this.panelUsers.Enabled = isAdmin; 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.Transparent;
            this.panelOrders.BackgroundImage = global::Csharp_Project.Properties.Resources.Orders_canvas;
            resources.ApplyResources(this.panelOrders, "panelOrders");
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
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.TabStop = true;
            this.panelProduct.Click += new System.EventHandler(this.panelProduct_Click);
            this.panelProduct.MouseLeave += new System.EventHandler(this.panelProduct_MouseLeave);
            this.panelProduct.MouseHover += new System.EventHandler(this.panelProduct_MouseHover);
            // 
            // FORM_HOME
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FORM_HOME_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panelUsers;
    }
}