using Final_System.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_System.Forms;
using Final_System.Repositories;
using Final_System.Model;
using Final_System.Utils;


namespace Final_System.Forms
{
    public partial class Staff_Dashboard : Form
    {
       
        userRepository userREpo;
        public Staff_Dashboard()
        {
            InitializeComponent();
            userREpo = new userRepository();
        }
        public void loadgrid()
        {
            userRepository userREpo = new userRepository();
            datagridBOOKINGstaff.DataSource = userREpo.Allstafff();
        }
        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            loadgrid();

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            using (AppointmentSystemEntities1 db = new AppointmentSystemEntities1())
            {
                if (String.IsNullOrEmpty(txtfnCONF.Text))
                {
                    errorProvider1.SetError(txtfnCONF, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtLnCONF.Text))
                {
                    errorProvider1.SetError(txtLnCONF, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtMidCONF.Text))
                {
                    errorProvider1.SetError(txtMidCONF, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtADDresCONF.Text))
                {
                    errorProvider1.SetError(txtADDresCONF, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtEmailCONF.Text))
                {
                    errorProvider1.SetError(txtEmailCONF, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtPhoneCONF.Text))
                {
                    errorProvider1.SetError(txtPhoneCONF, "Empty Field");
                    return;
                }
             

                tblUser book = new tblUser();

                book.userFirstname = txtfnCONF.Text;
                book.userLastname = txtLnCONF.Text;
                book.usermid = txtMidCONF.Text;
                book.userAddress = txtADDresCONF.Text;

                book.userEmail = txtEmailCONF.Text;
                book.userNumber = txtPhoneCONF.Text;

                db.tblUser.Add(book);
                db.SaveChanges();

                txtfnCONF.Clear();
                txtLnCONF.Clear();
                txtMidCONF.Clear();
                txtADDresCONF.Clear();
                txtEmailCONF.Clear();
                txtPhoneCONF.Clear();

                MessageBox.Show("ACCEPTED!");

            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {

        }

      
        private void pbclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbclose1_Click(object sender, EventArgs e)
        {
        
        }

   
        private void datagridBOOKING_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDCONF.Text = datagridBOOKINGstaff.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtfnCONF.Text = datagridBOOKINGstaff.Rows[e.RowIndex].Cells["First_Name"].Value.ToString();
                txtLnCONF.Text = datagridBOOKINGstaff.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
                txtMidCONF.Text = datagridBOOKINGstaff.Rows[e.RowIndex].Cells["Middle_Initial"].Value.ToString();
                txtADDresCONF.Text = datagridBOOKINGstaff.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtEmailCONF.Text = datagridBOOKINGstaff.Rows[e.RowIndex].Cells["Email Address"].Value.ToString();
                txtPhoneCONF.Text = datagridBOOKINGstaff.Rows[e.RowIndex].Cells["Phone_Number"].Value.ToString();
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void datagridBOOKINGstaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
