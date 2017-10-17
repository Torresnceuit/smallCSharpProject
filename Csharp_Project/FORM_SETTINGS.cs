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
    public partial class FORM_SETTINGS : Form
    {
        public delegate void windowActDelegate(bool visible);
        public windowActDelegate windowAct;
        public delegate void colorChangeDelegate(Color cl);
        public colorChangeDelegate colorChange;
        public delegate void imageChangeDelegate(Image img);
        public imageChangeDelegate imageChange;
        private FORM_PASSWORD fmpw;
        string user;
        private string pass;
        private string type;
        private string fullname;
        private string phone;
        private string email;
        private int id;
        private Color bgColor;
        public FORM_SETTINGS(string usr, string pass, string type, string fullname, string phone, string email, int id, Color cl)
        {
            this.user = usr;
            this.pass = pass;
            this.type = type;
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
            this.id = id;
            this.bgColor = cl;
            InitializeComponent();
        }

        private void btnChangePass_MouseHover(object sender, EventArgs e)
        {
            btnChangePass.BackColor = Color.LimeGreen;
            btnChangePass.ForeColor = Color.Black;
        }

        private void btnChangePass_MouseLeave(object sender, EventArgs e)
        {
            btnChangePass.BackColor = SystemColors.ActiveCaptionText;
            btnChangePass.ForeColor = Color.White;
        }

        private void btnChangeBackground_MouseHover(object sender, EventArgs e)
        {
            btnChangeBackground.BackColor = Color.LimeGreen;
            btnChangeBackground.ForeColor = Color.Black;
        }

        private void btnChangeBackground_MouseLeave(object sender, EventArgs e)
        {
            btnChangeBackground.BackColor = SystemColors.ActiveCaptionText;
            btnChangeBackground.ForeColor = Color.White;
        }

        private void btnChangeImage_MouseHover(object sender, EventArgs e)
        {
            btnChangeImage.BackColor = Color.LimeGreen;
            btnChangeImage.ForeColor = Color.Black;
        }

        private void btnChangeImage_MouseLeave(object sender, EventArgs e)
        {
            btnChangeImage.BackColor = SystemColors.ActiveCaptionText;
            btnChangeImage.ForeColor = Color.White;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            fmpw = new FORM_PASSWORD(this.user, this.pass, this.type, this.fullname, this.phone, this.email, this.id);
            fmpw.Show();
            
        }

        private void FORM_SETTINGS_Load(object sender, EventArgs e)
        {

        }

        private void FORM_SETTINGS_FormClosed(object sender, FormClosedEventArgs e)
        {
            windowAct(true);
            if (fmpw != null)
            {
                fmpw.Close();
            }
        }

        private void btnChangeBackground_Click(object sender, EventArgs e)
        {
            ColorDialog myColor = new ColorDialog();
            //Keep selecting a custom color
            myColor.AllowFullOpen = true;
            //Allow user to get help
            myColor.ShowHelp = true;
            // Sets the initial color select to the current text color.
            myColor.Color = this.bgColor;
            if (myColor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                colorChange(myColor.Color);
            }

            if(MessageBox.Show("Background Color has been changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                == DialogResult.OK){
                    this.Close();
            }

        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Bitmap file(*.bmp)|*.bmp|JPG file(*.JPG)|*.JPG|PNG file(*.PNG)|*.PNG|JPEG file(*.JPEG)|*.JPEG|anyfile(*.*)|*.*";
            img.FilterIndex = 4;
            if (img.ShowDialog() == DialogResult.OK)
            {
                imageChange(Image.FromFile(img.FileName));
            }

            if (MessageBox.Show("Background Image has been changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            colorChange(SystemColors.ButtonShadow);
            imageChange(null);

            if (MessageBox.Show("All settings have been default", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                this.Close();
            }
        }

        


    }
}
