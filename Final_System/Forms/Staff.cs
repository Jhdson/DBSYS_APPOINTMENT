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
            datagridBOOKING.DataSource = userREpo.UserTablesTable();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            using (AppointmentSystemEntities db = new AppointmentSystemEntities())
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




        



                db.tblUsers.Add(book);
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

        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            loadgrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbclose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void datagridBOOKING_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDCONF.Text = datagridBOOKING.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtfnCONF.Text = datagridBOOKING.Rows[e.RowIndex].Cells["First_Name"].Value.ToString();
                txtLnCONF.Text = datagridBOOKING.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
                txtMidCONF.Text = datagridBOOKING.Rows[e.RowIndex].Cells["Middle_Initial"].Value.ToString();
                txtADDresCONF.Text = datagridBOOKING.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtEmailCONF.Text = datagridBOOKING.Rows[e.RowIndex].Cells["Email Address"].Value.ToString();
                txtPhoneCONF.Text = datagridBOOKING.Rows[e.RowIndex].Cells["Phone_Number"].Value.ToString();
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
