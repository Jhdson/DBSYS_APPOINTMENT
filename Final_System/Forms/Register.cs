using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_System.AppData;

namespace Final_System.Forms
{
    public partial class frm_register : Form
    {
        AppointmentSystemEntities db;
        public frm_register()
        {
            InitializeComponent();
            db = new AppointmentSystemEntities();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_lastname.Text))
            {
                errorproviter1.SetError(txt_lastname, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_firstname.Text))
            {
                errorproviter1.SetError(txt_firstname, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_middlei.Text))
            {
                errorproviter1.SetError(txt_middlei, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_address.Text))
            {
                errorproviter1.SetError(txt_address, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_Emailadd.Text))
            {
                errorproviter1.SetError(txt_Emailadd, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_phone.Text))
            {
                errorproviter1.SetError(txt_phone, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_username.Text))
            {
                errorproviter1.SetError(txt_username, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_password.Text))
            {
                errorproviter1.SetError(txt_password, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_confirmpass.Text))
            {
                errorproviter1.SetError(txt_confirmpass, "Empty Field");
                return;
            }
            if (!txt_password.Text.Equals(txt_confirmpass.Text))
            {
                errorproviter1.Clear();
                errorproviter1.SetError(txt_confirmpass, "Password not match");
                return;
            }

            tblUser UserTBL = new tblUser();
            UserTBL.userLastname = txt_lastname.Text;
            UserTBL.userFirstname = txt_firstname.Text;
            UserTBL.usermid = txt_middlei.Text;
            UserTBL.userAddress = txt_address.Text;
            UserTBL.userEmail = txt_Emailadd.Text;
            UserTBL.userNumber = txt_phone.Text;
            UserTBL.userName = txt_username.Text;
            UserTBL.userPass = txt_password.Text;
            UserTBL.roleID = 1;

            db.tblUsers.Add(UserTBL);
            db.SaveChanges();

            txt_lastname.Clear();
            txt_firstname.Clear();
            txt_middlei.Clear();
            txt_address.Clear();
            txt_Emailadd.Clear();
            txt_phone.Clear();
            txt_username.Clear();
            txt_password.Clear();
            txt_confirmpass.Clear();
            MessageBox.Show("Registed!");
            this.Close();
            new Login_form().Show();
        }

        private void pbclose2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbclose2, "Close");
        }

        private void pbminii2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pbminii2, "Minimize");
        }


        private void pbminii2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}