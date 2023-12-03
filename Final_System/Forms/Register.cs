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
        }
    }
}
