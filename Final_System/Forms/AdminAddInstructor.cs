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
using Final_System.AppData;
using Final_System.Repositories;
using Final_System.Utils;
using Final_System.Model;

namespace Final_System.Forms
{
    public partial class AdminAddInstructor : Form
    {
        userRepository userRepo;
        AppointmentSystemEntities db;

        int? userIDnumber = null;
        int? instructorselId = null;

        public AdminAddInstructor()
        {
            InitializeComponent();
            db = new AppointmentSystemEntities();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            pnlInstructor.BringToFront();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnlUsers.BringToFront();
        }

        public void LoadParticipants()
        {
            dataGridViewPARTICIPANTS.DataSource = userRepo.UserTablesTable();
        }
        public void LoadInstructor()
        {
            dataGridView1ins.DataSource = userRepo.InstructorTABLE();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            using (var db = new AppointmentSystemEntities())
            {


                String strOutputMsg = "";
                if (String.IsNullOrEmpty(TXTFIRSTNAME.Text))
                {
                    errorProviderCustom1.SetError(TXTFIRSTNAME, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(TXTLASTNAME.Text))
                {
                    errorProviderCustom1.SetError(TXTLASTNAME, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(TXTMID.Text))
                {
                    errorProviderCustom1.SetError(TXTMID, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(TXTADDRESS.Text))
                {
                    errorProviderCustom1.SetError(TXTADDRESS, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(TXTEMAIL.Text))
                {
                    errorProviderCustom1.SetError(TXTEMAIL, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(TXTPHONE.Text))
                {
                    errorProviderCustom1.SetError(TXTPHONE, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(TXTUSERNAME.Text))
                {
                    errorProviderCustom1.SetError(TXTUSERNAME, "Empty field");
                    return;
                }
                if (String.IsNullOrEmpty(TXTPASS.Text))
                {
                    errorProviderCustom1.SetError(TXTPASS, "Empty field");
                    return;
                }



                ErrorCode retValue = userRepo.InsertUserUsingStoredProf(TXTFIRSTNAME.Text, TXTLASTNAME.Text, TXTMID.Text, TXTADDRESS.Text,
                    TXTEMAIL.Text, TXTPHONE.Text, TXTUSERNAME.Text, TXTPASS.Text, ref strOutputMsg);
                if (retValue != ErrorCode.Success)
                {

                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadParticipants();

                    TXTFIRSTNAME.Clear();
                    TXTLASTNAME.Clear();
                    TXTMID.Clear();
                    TXTADDRESS.Clear();
                    TXTEMAIL.Clear();
                    TXTPHONE.Clear();
                    TXTUSERNAME.Clear();

                    TXTPASS.Clear();

                    MessageBox.Show("Registed Successfully!");
                }
                else
                {
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

/*
        private void datagridADMIN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userIDnumber = (Int32)datagridADMIN.Rows[e.RowIndex].Cells[0].Value;
                TXTFIRSTNAME.Text = datagridADMIN.Rows[e.RowIndex].Cells["First_Name"].Value.ToString();
                TXTLASTNAME.Text = datagridADMIN.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
                TXTMID.Text = datagridADMIN.Rows[e.RowIndex].Cells["Middle_Initial"].Value.ToString();
                TXTADDRESS.Text = datagridADMIN.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                TXTEMAIL.Text = datagridADMIN.Rows[e.RowIndex].Cells["Email Address"].Value.ToString();
                TXTPHONE.Text = datagridADMIN.Rows[e.RowIndex].Cells["Phone_Number"].Value.ToString();
                TXTUSERNAME.Text = datagridADMIN.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                TXTPASS.Text = datagridADMIN.Rows[e.RowIndex].Cells["Password"].Value.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
*/
        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";
            if (String.IsNullOrEmpty(TXTFIRSTNAME.Text))
            {
                errorProviderCustom1.SetError(TXTFIRSTNAME, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTLASTNAME.Text))
            {
                errorProviderCustom1.SetError(TXTLASTNAME, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTMID.Text))
            {
                errorProviderCustom1.SetError(TXTMID, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTADDRESS.Text))
            {
                errorProviderCustom1.SetError(TXTADDRESS, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTEMAIL.Text))
            {
                errorProviderCustom1.SetError(TXTEMAIL, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTPHONE.Text))
            {
                errorProviderCustom1.SetError(TXTPHONE, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTUSERNAME.Text))
            {
                errorProviderCustom1.SetError(TXTUSERNAME, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTPASS.Text))
            {
                errorProviderCustom1.SetError(TXTPASS, "Empty field");
                return;
            }



            ErrorCode retValue = userRepo.UpdateUserUsingStoredProf(userIDnumber, TXTFIRSTNAME.Text, TXTLASTNAME.Text, TXTMID.Text, TXTADDRESS.Text,
                     TXTEMAIL.Text, TXTPHONE.Text, TXTUSERNAME.Text, TXTPASS.Text, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {


                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadParticipants();

                TXTFIRSTNAME.Clear();
                TXTLASTNAME.Clear();
                TXTMID.Clear();
                TXTADDRESS.Clear();
                TXTEMAIL.Clear();
                TXTPHONE.Clear();
                TXTUSERNAME.Clear();

                TXTPASS.Clear();

                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";
            if (String.IsNullOrEmpty(TXTFIRSTNAME.Text))
            {
                errorProviderCustom1.SetError(TXTFIRSTNAME, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTLASTNAME.Text))
            {
                errorProviderCustom1.SetError(TXTLASTNAME, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTMID.Text))
            {
                errorProviderCustom1.SetError(TXTMID, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTADDRESS.Text))
            {
                errorProviderCustom1.SetError(TXTADDRESS, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTEMAIL.Text))
            {
                errorProviderCustom1.SetError(TXTEMAIL, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTPHONE.Text))
            {
                errorProviderCustom1.SetError(TXTPHONE, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTUSERNAME.Text))
            {
                errorProviderCustom1.SetError(TXTUSERNAME, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(TXTPASS.Text))
            {
                errorProviderCustom1.SetError(TXTPASS, "Empty field");
                return;
            }
            ErrorCode retValue = userRepo.DeleteUserUsingStoredProf(userIDnumber, ref strOutputMsg);


            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadParticipants();

                TXTFIRSTNAME.Clear();
                TXTLASTNAME.Clear();
                TXTMID.Clear();
                TXTADDRESS.Clear();
                TXTEMAIL.Clear();
                TXTPHONE.Clear();
                TXTUSERNAME.Clear();

                TXTPASS.Clear();
                MessageBox.Show("Deleted Successfully!");
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pbclose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbclose1_MouseHover(object sender, EventArgs e)
        {


        }

        private void txtinsNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlInstructor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddINS_Click(object sender, EventArgs e)
        {
            String instructorID = txtinsNumber.Text;
            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(instructorID))
            {
                errorProviderCustom1.SetError(txtinsNumber, "Empty Field!");
                return;
            }

            ErrorCode retValue = userRepo.AddInstructorUsingStoredProf((Int32)instructorselId, txtfnameins.Text, txtlnameins.Text,
                txtexins.Text, txtcontactins.Text, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInstructor();

                txtinsNumber.Clear();
                txtfnameins.Clear();
                txtlnameins.Clear();
                txtexins.Clear();
                txtcontactins.Clear();
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUPDATEINS_Click(object sender, EventArgs e)
        {
            String instructorID = txtinsNumber.Text;
            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(instructorID))
            {
                errorProviderCustom1.SetError(txtinsNumber, "Empty Field!");
                return;
            }

            ErrorCode retValue = userRepo.UpdateInstructorUsingStoredProf((Int32)instructorselId, txtfnameins.Text, txtlnameins.Text,
                txtexins.Text, txtcontactins.Text, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInstructor();

                txtinsNumber.Clear();
                txtfnameins.Clear();
                txtlnameins.Clear();
                txtexins.Clear();
                txtcontactins.Clear();
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDELETEINS_Click(object sender, EventArgs e)
        {
            String instructorID = txtinsNumber.Text;
            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(instructorID))
            {
                errorProviderCustom1.SetError(txtinsNumber, "Empty Field!");
                return;
            }

            ErrorCode retValue = userRepo.DeleteInstructorUsingStoredProf((Int32)instructorselId, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInstructor();

                txtinsNumber.Clear();
                txtfnameins.Clear();
                txtlnameins.Clear();
                txtexins.Clear();
                txtcontactins.Clear();
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1ins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1ins.Rows[e.RowIndex].Cells[0].Value != null)

                    instructorselId = (Int32)dataGridView1ins.Rows[e.RowIndex].Cells[0].Value;
                txtinsNumber.Text = dataGridView1ins.Rows[e.RowIndex].Cells["Room_Number"].Value.ToString();
                txtfnameins.Text = dataGridView1ins.Rows[e.RowIndex].Cells["Room_Number"].Value.ToString();
                txtlnameins.Text = dataGridView1ins.Rows[e.RowIndex].Cells["Room_Type"].Value.ToString();
                txtexins.Text = dataGridView1ins.Rows[e.RowIndex].Cells["Aircon"].Value.ToString();
                txtcontactins.Text = dataGridView1ins.Rows[e.RowIndex].Cells["Minimum_Guest"].Value.ToString();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dataGridViewPARTICIPANTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userIDnumber = (Int32)dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells[0].Value;
                TXTFIRSTNAME.Text = dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells["First_Name"].Value.ToString();
                TXTLASTNAME.Text = dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
                TXTMID.Text = dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells["Middle_Initial"].Value.ToString();
                TXTADDRESS.Text = dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                TXTEMAIL.Text = dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells["Email Address"].Value.ToString();
                TXTPHONE.Text = dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells["Phone_Number"].Value.ToString();
                TXTUSERNAME.Text = dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                TXTPASS.Text = dataGridViewPARTICIPANTS.Rows[e.RowIndex].Cells["Password"].Value.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}





















































        /*
           public ErrorCode InsertUserUsingStoredProf(string userLastname, string userFirstname, string usermiddleIn, string userAddress, string userEmail, string userNumber, string uusername
            , string userpass, int roleID, string createdBY, string Response)
        {
            using (db = new AppointmentSystemEntities())
            {
                try
                {
                    
                    db.sp_InsertUser(userLastname, userFirstname, usermiddleIn, userAddress,
                        userEmail, userNumber, uusername, userpass, roleID, createdBY);
                    Response = " Inserted ";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
         
        private void btnADD_Click(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(TXTUSERID.Text, out userId))
            {
                errorProviderCustom1.SetError(TXTUSERID, "Invalid User ID!");
                return;
            }

            string strOutputMsg = "";

            // Validation to ensure the userID is not zero or negative if that's a requirement
            if (userId <= 0)
            {
                errorProviderCustom1.SetError(TXTUSERID, "Invalid User ID!");
                return;
            }

            // Call the method to add a user using the stored procedure
            ErrorCode retValue = userRepo.ADDUserUsingStoredProf(
                userId,
                TXTFIRSTNAME.Text,
                TXTLASTNAME.Text,
                TXTMID.Text,
                TXTADDRESS.Text,
                TXTEMAIL.Text,
                TXTPHONE.Text,
                TXTUSERNAME.Text,
                TXTPASS.Text,
                ref strOutputMsg
            );

            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally clear textboxes or perform other actions upon successful addition
                loadAdmin();
            }
        }





        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            String userID = TXTUSERID.Text;

            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(userID))
            {
                errorProviderCustom1.SetError(TXTUSERID, "Empty Field!");
                return;
            }

            ErrorCode retValue = userRepo.UpdateUserUsingStoredProf((Int32)userIDnumber, TXTFIRSTNAME.Text, TXTLASTNAME.Text, TXTMID.Text, TXTADDRESS.Text,
                TXTEMAIL.Text, TXTPHONE.Text, TXTUSERNAME.Text, TXTPASS.Text, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                errorProviderCustom1.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadAdmin();

                userIDnumber = null;
                TXTFIRSTNAME.Text = retValue.ToString();
                TXTLASTNAME.Text = retValue.ToString();
                TXTMID.Text = retValue.ToString();
                TXTADDRESS.Text = retValue.ToString();
                TXTEMAIL.Text = retValue.ToString();
                TXTPHONE.Text = retValue.ToString();
                TXTUSERNAME.Text = retValue.ToString();
                TXTPASS.Text = retValue.ToString();

            }

        }

        private void datagridADMIN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datagridADMIN.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    userIDnumber = (Int32)datagridADMIN.Rows[e.RowIndex].Cells[0].Value;
                    TXTLASTNAME.Text = datagridADMIN.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
                    TXTFIRSTNAME.Text = datagridADMIN.Rows[e.RowIndex].Cells["First_Name"].Value.ToString();
                    TXTMID.Text = datagridADMIN.Rows[e.RowIndex].Cells["Middle_Initial"].Value.ToString();
                    TXTADDRESS.Text = datagridADMIN.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                    TXTEMAIL.Text = datagridADMIN.Rows[e.RowIndex].Cells["Email_Address"].Value.ToString();
                    TXTPHONE.Text = datagridADMIN.Rows[e.RowIndex].Cells["Phone_Number"].Value.ToString();
                    TXTUSERNAME.Text = datagridADMIN.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                    TXTPASS.Text = datagridADMIN.Rows[e.RowIndex].Cells["UserPassword"].Value.ToString();


                }
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string userID = TXTUSERID.Text;
            String strOutputMsg = "";
            if (String.IsNullOrEmpty(userID))
            {
                errorProviderCustom1.SetError(TXTUSERID, "Empty Field!");
                return;
            }

            ErrorCode retValue = userRepo.DeleteUserUsingStoredProf((Int32)userIDnumber, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                errorProviderCustom1.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadAdmin();


                userIDnumber = null;
                TXTFIRSTNAME.Text = retValue.ToString();
                TXTLASTNAME.Text = retValue.ToString();
                TXTMID.Text = retValue.ToString();
                TXTADDRESS.Text = retValue.ToString();
                TXTEMAIL.Text = retValue.ToString();
                TXTPHONE.Text = retValue.ToString();
                TXTUSERNAME.Text = retValue.ToString();
                TXTPASS.Text = retValue.ToString();

            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TXTUSERID_TextChanged(object sender, EventArgs e)
        {

        }

  
        private void btnAddINS_Click(object sender, EventArgs e)
        {
            int instructorId;
            if (!int.TryParse(txtinsNumber.Text, out instructorId))
            {
                errorProviderCustom1.SetError(txtinsNumber, "Invalid Instructor ID!");
                return;
            }

            string strOutputMsg = "";

            // Validation to ensure the userID is not zero or negative if that's a requirement
            if (instructorId <= 0)
            {
                errorProviderCustom1.SetError(txtinsNumber, "Invalid Instructor ID!");
                return;
            }
            ErrorCode retValue = userRepo.AddInstructorUsingStoredProf((Int32)instructorId, txtfnameins.Text, txtlnameins.Text, txtexins.Text, txtcontactins.Text, ref strOutputMsg);
            {
                if (retValue != ErrorCode.Success)
                {
                    errorProviderCustom1.Clear();
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAdmin();

                   
                    txtinsNumber.Text = retValue.ToString();
                    txtfnameins.Text = retValue.ToString();
                    txtlnameins.Text = retValue.ToString();
                    txtexins.Text = retValue.ToString();
                    txtcontactins.Text = retValue.ToString();

                }
                else
                {
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
           
            }
        }

        private void btnUPDATEINS_Click(object sender, EventArgs e)
        {
            int instructorId;
            if (!int.TryParse(txtinsNumber.Text, out instructorId))
            {
                errorProviderCustom1.SetError(txtinsNumber, "Invalid Instructor ID!");
                return;
            }

            string strOutputMsg = "";

            // Validation to ensure the userID is not zero or negative if that's a requirement
            if (instructorId <= 0)
            {
                errorProviderCustom1.SetError(txtinsNumber, "Invalid Instructor ID!");
                return;
            }
            ErrorCode retValue = userRepo.UpdateInstructorUsingStoredProf((Int32)instructorId, txtfnameins.Text, txtlnameins.Text, txtexins.Text, txtcontactins.Text, ref strOutputMsg);
            {
                if (retValue != ErrorCode.Success)
                {
                    errorProviderCustom1.Clear();
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAdmin();

                  
                    txtinsNumber.Text = retValue.ToString();
                    txtfnameins.Text = retValue.ToString();
                    txtlnameins.Text = retValue.ToString();
                    txtexins.Text = retValue.ToString();
                    txtcontactins.Text = retValue.ToString();

                }
                else
                {
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

     
            private void btnDELETEINS_Click(object sender, EventArgs e)
            {
                String instructorID = txtinsNumber.Text;

                String strOutputMsg = "";
                // Validation not allow empty or null value
                if (String.IsNullOrEmpty(instructorID))
                {
                    errorProviderCustom1.SetError(txtinsNumber, "Empty Field!");
                    return;
                }

                ErrorCode retValue = userRepo.DeleteInstructorUsingStoredProf((Int32)instructorId, ref strOutputMsg);
                if (retValue != ErrorCode.Success)
                {
                    errorProviderCustom1.Clear();
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAdmin();

                    instructorId = null;
                    txtinsNumber.Clear();
                    txtfnameins.Text = retValue.ToString();
                    txtlnameins.Text = retValue.ToString();
                    txtexins.Text = retValue.ToString();
                    txtcontactins.Text = retValue.ToString();
            }
                else
                {
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                instructorId = (Int32)datagridADMIN.Rows[e.RowIndex].Cells[0].Value;
                txtfnameins.Text = datagridADMIN.Rows[e.RowIndex].Cells["First_Name"].Value.ToString();
                txtlnameins.Text = datagridADMIN.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
                txtexins.Text = datagridADMIN.Rows[e.RowIndex].Cells["Experties"].Value.ToString();
                txtcontactins.Text = datagridADMIN.Rows[e.RowIndex].Cells["Contact_No."].Value.ToString();
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
   
        
    }

}
        */











