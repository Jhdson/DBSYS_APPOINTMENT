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

namespace Final_System.Forms
{
    public partial class UserDashboard : Form
    {
        public int Instuctorselectd = 0;
        userRepository userRepo;
        public UserDashboard()
        {
            InitializeComponent();
            userRepo = new userRepository();
        }

        private void Book_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";

            if (String.IsNullOrEmpty(txtChckFN.Text))
            {
                errorProviderCustom1.SetError(txtChckFN, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtChckLN.Text))
            {
                errorProviderCustom1.SetError(txtChckLN, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtChckADD.Text))
            {
                errorProviderCustom1.SetError(txtChckADD, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtChckEmail.Text))
            {
                errorProviderCustom1.SetError(txtChckEmail, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtChcknUMBER.Text))
            {
                errorProviderCustom1.SetError(txtChcknUMBER, "Empty Field!");
                return;
            }
            
            

            ErrorCode retValue = userRepo.InsertCheckOUTUsingStoredProf(Instuctorselectd, txtChckFN.Text, txtChckLN.Text, txtChckADD.Text, txtChckEmail.Text, txtChcknUMBER.Text, 
                Convert.ToDateTime(dtpstart.Text), Convert.ToDateTime(dtpexpire.Text), ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChckFN.Clear();
                txtChckLN.Clear();
                txtChckADD.Clear();
                txtChckEmail.Clear();
                txtChcknUMBER.Clear();
                dtpstart.ResetText();
                dtpexpire.ResetText();
            
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            loadInstructor();
        }
        private void loadInstructor()
        {
            dataGridViewBOOKins.DataSource = userRepo.ALLINSTRUCTOR();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            pnlINSTUCTOR.BringToFront();
        }

        private void btnCheckOUT_Click(object sender, EventArgs e)
        {
            PNLCHECKOUT.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserDashboard ucerD = new UserDashboard();

            if (String.IsNullOrEmpty(txtBOOKFN.Text) || (String.IsNullOrEmpty(txtBOOKLN.Text)) || (String.IsNullOrEmpty(txtBOOKexpert.Text)) || (String.IsNullOrEmpty(txtBOOKContact.Text)))
            {
                MessageBox.Show("Please Select Instructor!");
                return;
            }

            ucerD.Instuctorselectd = Instuctorselectd;
            ucerD.lblfn.Text = txtBOOKFN.Text;
            ucerD.lblln.Text = txtBOOKLN.Text;
            ucerD.lblexp.Text = txtBOOKexpert.Text;
            ucerD.lblnum.Text = txtBOOKContact.Text;
        
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBOOKins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewBOOKins.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    Instuctorselectd = (Int32)dataGridViewBOOKins.Rows[e.RowIndex].Cells[0].Value;
                    txtBOOKFN.Text = dataGridViewBOOKins.Rows[e.RowIndex].Cells["Instructor's First Name"].Value.ToString() ;
                    txtBOOKLN.Text = dataGridViewBOOKins.Rows[e.RowIndex].Cells["Instructor's Last Name"].Value.ToString();
                    txtBOOKexpert.Text = dataGridViewBOOKins.Rows[e.RowIndex].Cells["Instructor' Expertise"].Value.ToString();
                    txtBOOKContact.Text = dataGridViewBOOKins.Rows[e.RowIndex].Cells["Instructor's Contact No."].Value.ToString();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("1 INSTRUCTOR at a time!");
                dataGridViewBOOKins.ClearSelection();
                txtBOOKFN.Clear();
                txtBOOKLN.Clear();
                txtBOOKexpert.Clear();
                txtBOOKContact.Clear();
            
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtChckFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChcknUMBER_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBOOKFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pbclose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbclose1_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
