using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Project
{
    public partial class FORM_HOME : Form
    {
        public string userType;
        bool isAdmin;
        private string user;
        private string pass;
        private string type;
        private string fullname;
        private string phone;
        private string email;
        private int id;
        
        public FORM_HOME(bool Admin, string usr, string pass, string type, string fullname, string phone, string email, int id)
        {
            isAdmin = Admin;
            this.user = usr;
            this.pass = pass;
            this.type = type;
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
            this.id = id;
            InitializeComponent();
            this.lblUser.Text = user;
            this.lblTime.Text = DateTime.Now.ToString();
            
            
 
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CATEGORIES fmcg = new FORM_MANAGE_CATEGORIES();
            fmcg.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER fmcm = new FORM_MANAGE_CUSTOMER();
            fmcm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_ORDER fmo = new FORM_MANAGE_ORDER();
            fmo.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_USER fmus = new FORM_MANAGE_USER();
            fmus.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_PRODUCT fmp = new FORM_MANAGE_PRODUCT();
            fmp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FORM_HOME_Load(object sender, EventArgs e)
        {

        }

        private void panelProduct_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_PRODUCT fmp = new FORM_MANAGE_PRODUCT();
            fmp.Show();
            fmp.windowAct = new FORM_MANAGE_PRODUCT.windowActDelegate(windowAct);
            this.Visible = false;
        }

        private void panelCategory_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CATEGORIES fmcg = new FORM_MANAGE_CATEGORIES();
            fmcg.Show();
            fmcg.windowAct = new FORM_MANAGE_CATEGORIES.windowActDelegate(this.windowAct);
            this.Visible = false;
        }

        private void panelCustomers_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER fmcm = new FORM_MANAGE_CUSTOMER();
            fmcm.Show();
            fmcm.windowAct = new FORM_MANAGE_CUSTOMER.windowActDelegate(windowAct);
            this.Visible = false;
        }

        private void panelOrders_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_ORDER fmo = new FORM_MANAGE_ORDER();
            fmo.Show();
            fmo.windowAct = new FORM_MANAGE_ORDER.windowActDelegate(windowAct);
            this.Visible = false;
        }

        private void panelUsers_Click(object sender, EventArgs e)
        {

            if (isAdmin)
            {
                FORM_MANAGE_USER fmus = new FORM_MANAGE_USER();
                fmus.Show();
                fmus.windowAct = new FORM_MANAGE_USER.windowActDelegate(windowAct);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("You don't have access right", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void panelProduct_MouseHover(object sender, EventArgs e)
        {
            this.panelProduct.BackgroundImage = global::Csharp_Project.Properties.Resources.Product_canvas_over;
            this.panelProduct.BackColor = SystemColors.ActiveCaption;
        }

        private void panelProduct_MouseLeave(object sender, EventArgs e)
        {
            this.panelProduct.BackgroundImage = global::Csharp_Project.Properties.Resources.Product_canvas;
            this.panelProduct.BackColor = Color.Transparent;
        }

        private void panelCategory_MouseHover(object sender, EventArgs e)
        {
            this.panelCategory.BackgroundImage = global::Csharp_Project.Properties.Resources.Categories_canvas_over;
            this.panelCategory.BackColor = SystemColors.ActiveCaption;
        }

        private void panelCategory_MouseLeave(object sender, EventArgs e)
        {
            this.panelCategory.BackgroundImage = global::Csharp_Project.Properties.Resources.Categories_canvas;
            this.panelCategory.BackColor = Color.Transparent;
        }

        private void panelCustomers_MouseHover(object sender, EventArgs e)
        {
            this.panelCustomers.BackgroundImage = global::Csharp_Project.Properties.Resources.Customers_canvas_over;
            this.panelCustomers.BackColor = SystemColors.ActiveCaption;
        }

        private void panelCustomers_MouseLeave(object sender, EventArgs e)
        {
            this.panelCustomers.BackgroundImage = global::Csharp_Project.Properties.Resources.Customers_canvas;
            this.panelCustomers.BackColor = Color.Transparent;
        }

        private void panelOrders_MouseHover(object sender, EventArgs e)
        {
            this.panelOrders.BackgroundImage = global::Csharp_Project.Properties.Resources.Orders_canvas_over;
            this.panelOrders.BackColor = SystemColors.ActiveCaption;
        }

        private void panelOrders_MouseLeave(object sender, EventArgs e)
        {
            this.panelOrders.BackgroundImage = global::Csharp_Project.Properties.Resources.Orders_canvas;
            this.panelOrders.BackColor = Color.Transparent;
        }

        private void panelUsers_MouseHover(object sender, EventArgs e)
        {
            this.panelUsers.BackgroundImage = global::Csharp_Project.Properties.Resources.Users_canvas_over;
            this.panelUsers.BackColor = SystemColors.ActiveCaption;
        }

        private void panelUsers_MouseLeave(object sender, EventArgs e)
        {
            this.panelUsers.BackgroundImage = global::Csharp_Project.Properties.Resources.Users_canvas;
            this.panelUsers.BackColor = Color.Transparent;
        }
        public void windowAct(bool visible)
        {
            this.Visible = visible;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.panelSettings.BackgroundImage = global::Csharp_Project.Properties.Resources.Settings_canvas_over;
            this.panelSettings.BackColor = SystemColors.ActiveCaption;
        }

        private void panelSettings_MouseLeave(object sender, EventArgs e)
        {
            this.panelSettings.BackgroundImage = global::Csharp_Project.Properties.Resources.Settings_canvas;
            this.panelSettings.BackColor = Color.Transparent;
        }

        private void panelSettings_Click(object sender, EventArgs e)
        {
            FORM_SETTINGS fmst = new FORM_SETTINGS(this.user,this.pass,this.type,this.fullname,this.phone,this.email,this.id,this.BackColor);
            this.Visible = false;
            fmst.Show();
            fmst.windowAct = new FORM_SETTINGS.windowActDelegate(this.windowAct);
            fmst.colorChange = new FORM_SETTINGS.colorChangeDelegate(this.colorChange);
            fmst.imageChange = new FORM_SETTINGS.imageChangeDelegate(this.imageChange);
        }

        public void colorChange(Color cl)
        {
            this.BackColor = cl;
        }

        public void imageChange(Image img)
        {
            this.BackgroundImage = img;
            
        }
        


        

        

    }
}
