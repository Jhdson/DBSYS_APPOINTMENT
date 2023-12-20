using Final_System.Forms;
using Final_System.Model;
using Final_System.Repositories;
using Final_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_System
{
    public partial class Login_form : Form
    {
        userRepository repo;
        public Login_form()
        {
            InitializeComponent();
            repo = new userRepository();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new frm_register().Show();
        }

     

        private void pbmini1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pbmini1, "minize");
        }

        private void pbmini1_Click(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pbmini1, "minize");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textUSERNAME.Text))
            {
                
                errorProviderCustom.SetError(textUSERNAME, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(textPASSWORD.Text))
            {
                errorProviderCustom.SetError(textPASSWORD, "Empty Field!");

                return;
            }

            var userLogged = repo.GetUserByUsername(textUSERNAME.Text);

            if (userLogged != null)
            {
                if (userLogged.userPass.Equals(textPASSWORD.Text))
                {
                    UserLogged.GetInstance().User = userLogged;

                    switch ((Roles)userLogged.roleID)
                    {
                        case Roles.User:
                            new UserDashboard().Show();
                            this.Hide();
                            break;
                        case Roles.Staff:
                            new Staff_Dashboard().Show();
                            this.Hide();
                            break;
                        case Roles.Admin:
                            new AdminAddInstructor().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtnSHOW_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSHOW.Checked == false)
            {
                textPASSWORD.UseSystemPasswordChar = false;
            }
            else
            { 
                textPASSWORD.UseSystemPasswordChar = true;
            }
            
        }
        private Boolean showPassword;
        private void button1_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;


            if (showPassword)
            {
                textPASSWORD.PasswordChar = '\0';
            }
            else
            {
                textPASSWORD.PasswordChar = '*';
            }
        }

        private void textPASSWORD_TextChanged(object sender, EventArgs e)
        {
            textPASSWORD.PasswordChar = '*';
        }
    }
}
