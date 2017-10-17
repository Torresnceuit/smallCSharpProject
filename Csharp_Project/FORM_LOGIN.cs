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
    public partial class FORM_LOGIN : Form
    {
        
        Login log = new Login();
        public FORM_LOGIN()
        {
            InitializeComponent();
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        // login
        private void PANEL_LOGIN_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            DataTable table = new DataTable();
            table = log.login(TB_USERNAME.Text, TB_PASSWORD.Text);
            if (table.Rows.Count > 0)
            {
                //if the user is admin 
                // => hide the current form and show the home form
                if (table.Rows[0][3].ToString() == "admin")
                {
                    //this.Hide();
                    FORM_HOME FH = new FORM_HOME(true, TB_USERNAME.Text, TB_PASSWORD.Text, "admin", table.Rows[0][4].ToString(), table.Rows[0][5].ToString(),table.Rows[0][6].ToString(), Convert.ToInt32(table.Rows[0][0]));
                    FH.Closed += (s, args) => this.Close();
                    FH.Show();
                    this.Visible = false;
                    
                    
                    

                }
                //else the user is not an admin 
                // => hide the current form and show the home form
                // => and don't show the user tab
                // => a simple user cannot see the user tab  
                else
                {

                    this.Hide();
                    FORM_HOME FH = new FORM_HOME(false, TB_USERNAME.Text, TB_PASSWORD.Text, table.Rows[0][2].ToString(), "user", table.Rows[0][4].ToString(), table.Rows[0][5].ToString(), Convert.ToInt32(table.Rows[0][0]));
                    FH.Closed += (s, args) => this.Close();
                    //FH.userToolStripMenuItem.Visible = false;
                    FH.Show();

                }
                
                

            }
            else
            {
                MessageBox.Show("Username Or Password Are Incorrect");
            }
        }

        // show the password characters or not
        private void CB_PASSWORD_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_PASSWORD.Checked)
            {
                TB_PASSWORD.UseSystemPasswordChar = true;
            }
            else
            {
                TB_PASSWORD.UseSystemPasswordChar = false;
            }
        }

        private void PANEL_CLOSE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FORM_LOGIN_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FORM_LOGIN_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void TB_PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

  
    }
}
