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

namespace Final_System.Forms
{
    public partial class AdminAddInstructor : Form
    {
        userRepository userRepo;
        AppointmentSystemEntities db;

        int? userIDnumber = null;

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

        private void loadAdmin()
        {
            datagridADMIN.DataSource = userRepo.UserTablesTable();
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
         */
        private void btnADD_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";
            ErrorCode retValue = userRepo.InsertUserUsingStoredProf(TXTFIRSTNAME.Text, TXTLASTNAME.Text, TXTMID.Text, TXTADDRESS.Text,
                TXTEMAIL.Text, TXTPHONE.Text, TXTUSERNAME.Text, TXTPASS.Text, TXTREPASS.Text, ref strOutputMsg);
            if (retValue != ErrorCode.Success)
            {
                MessageBox.Show(strOutputMsg, " Message ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadAdmin();
                TXTFIRSTNAME.Text = retValue.ToString();
                TXTLASTNAME.Text = retValue.ToString();
                TXTMID.Text = retValue.ToString();
                TXTADDRESS.Text = retValue.ToString();
                TXTEMAIL.Text = retValue.ToString();
                TXTPHONE.Text = retValue.ToString();
                TXTUSERNAME.Text = retValue.ToString();
                TXTPASS.Text = retValue.ToString();
                TXTREPASS.Text = retValue.ToString();
            }


            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                TXTEMAIL.Text, TXTPHONE.Text, TXTUSERNAME.Text, strOutputMsg, strOutputMsg);
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
                TXTREPASS.Text = retValue.ToString();
            }

        }

        private void datagridADMIN_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    TXTREPASS.Text = datagridADMIN.Rows[e.RowIndex].Cells["UserPassword"].Value.ToString();

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
                TXTREPASS.Text = retValue.ToString();
            }
            else
            {
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
    
}











