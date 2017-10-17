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
    public partial class FORM_PASSWORD : Form
    {
        User user;
        private string curUser;
        private string pass;
        private string type;
        private string fullname;
        private string phone;
        private string email;
        private int id;
        public FORM_PASSWORD(string curUsr, string pass, string type, string fullname, string phone, string email, int id)
        {
            curUser = curUsr;
            this.pass = pass;
            this.type = type;
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
            this.id = id;
            InitializeComponent();
            user = new User();
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LimeGreen;
            btnSave.ForeColor = Color.Black;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = SystemColors.ActiveCaptionText;
            btnSave.ForeColor = Color.White;
        }

        private void save()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == txtConfirmPass.Text)
            {
                if (txtConfirmPass.Text == this.pass)
                {
                    try
                    {
                        user.updateUser(this.curUser, this.fullname, this.type, txtNewPass.Text, this.phone, this.email, this.id);
                        if (MessageBox.Show("Password has been successfully changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            == DialogResult.OK)
                        {
                            txtOldPass.Text = "";
                            txtConfirmPass.Text = "";
                            txtNewPass.Text = "";
                        }
                        this.pass = txtNewPass.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ocured when trying to update password");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert a valid password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Your old password is not matched", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
