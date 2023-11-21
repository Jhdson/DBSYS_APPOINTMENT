using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_System.Forms
{
    public partial class frm_register : Form
    {
         Final_SystemEntities
        public frm_register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_lastname.Text))
            {
                ErrorProvider.SetError(txt_lastname, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_firstname.Text))
            {
                ErrorProvider.SetError(txt_firstname, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_middlei.Text))
            {
                ErrorProvider.SetError(txt_middlei, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_address.Text))
            {
                ErrorProvider.SetError(txt_address, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_Emailadd.Text))
            {
                ErrorProvider.SetError(txt_Emailadd, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_phone.Text))
            {
                ErrorProvider.SetError(txt_phone, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_username.Text))
            {
                ErrorProvider.SetError(txt_username, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_password.Text))
            {
                ErrorProvider.SetError(txt_password, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txt_confirmpass.Text))
            {
                ErrorProvider.SetError(txt_confirmpass, "Empty Field");
                return;
            }
        }
    }
}
