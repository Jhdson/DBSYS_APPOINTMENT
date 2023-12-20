using Final_System.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_System.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Final_System.Model;


namespace Final_System.Repositories
{
    public class userRepository
    {
        private AppointmentSystemEntities1 db;

        public userRepository()
        {
            db = new AppointmentSystemEntities1();
        }

       public tblUser GetUserByUsername(String username)
        {
            using (db = new AppointmentSystemEntities1())
            {
                return db.tblUser.Where(m => m.userName == username).FirstOrDefault();
               
            }
        }
        public TblInstructor GetInstructorByFirstname(String instructorfName)
        {
            using (db = new AppointmentSystemEntities1())
            {
             
                return db.TblInstructor.Where(m => m.instructorFName == instructorfName).FirstOrDefault();
            }
        }
        public List<vw_allAppointment> AllAPPOINTMENTS()
        {
            using (db = new AppointmentSystemEntities1())
            {
                return db.vw_allAppointment.ToList();
            }
        }
       /* public List<vw_> aALLINSTRUCTOR()
        {
            using (db = new AppointmentSystemEntities())
            {
                return db.vw_.ToList();
            }
        }*/
        public List<vw_InsTable> ALLINSTRUCTOR()
        {
            using (db = new AppointmentSystemEntities1())
            {
                return db.vw_InsTable.ToList();
            }
        }
      /*  public List<vw_CheckOut> AllCheckOutTable()
        {
            using (db = new AppointmentsystemEntities())
            { 
                return db.vw_CheckOut.ToList();
            }
        }*/
        public List<vw_INstaffBook> Allstafff()
        {
            using (db = new AppointmentSystemEntities1())
            {
                return db.vw_INstaffBook.ToList();
            }
        }
        public List<vw_adminUSER> adminUser()
        {
            using (db = new AppointmentSystemEntities1())
            {
                return db.vw_adminUSER.ToList();
            }
        }

        public List<vw_UserTable> UserTablesTable()
        {
            using (db = new AppointmentSystemEntities1())
            {
                return db.vw_UserTable.ToList();
            }
        }
        public List<vw_InsTable> InstructorTABLE()
        {
            using(db = new AppointmentSystemEntities1())
            {
                return db.vw_InsTable.ToList();
            }
        }
        public ErrorCode InsertUserUsingStoredProf(string userFirstname, string userLastname, string userAddress, string userEmail, string userNumber, string uusername
            , string userpass, ref string Response)
        {
            using (db = new AppointmentSystemEntities1())
            {
                try
                {
                    
                    db.sp_InsertUser(userFirstname, userLastname, userAddress,
                        userEmail, userNumber, uusername, userpass);
                    Response = " Inserted Successfully";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public ErrorCode ADDUserUsingStoredProf(int? userID,string userFirstname, string userLastname, string usermiddleIn, string userAddress, string userEmail, string userNumber, string uusername
            , string userpass, ref string Response)
        {
            using (db = new AppointmentSystemEntities1())
            {
                try
                {

                    db.sp_INSERTUSERr(userID,userFirstname, userLastname, usermiddleIn, userAddress,
                        userEmail, userNumber, uusername, userpass);
                    Response = " Added Successfully";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }


        public ErrorCode UpdateUserUsingStoredProf(int? userID, string userFirstname, string userLastname, string userAddress, string userEmail, string userNumber, string uusername
            , string userpass, ref string Response)
        {
            using (db = new AppointmentSystemEntities1())
            {
                try
                {

                    db.sp_UPDATEUSER(userID, userFirstname, userLastname, userAddress,
                        userEmail, userNumber, uusername, userpass);
                    Response = " Updated Successfully";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public ErrorCode DeleteUserUsingStoredProf(int? userID, ref String Response)
        {
            using (db = new AppointmentSystemEntities1())
            {
                try
                {

                    db.sp_deleteUSER(userID);
                    Response = "Deleted";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }

        public ErrorCode AddInstructorUsingStoredProf( String instructorLName, String instructorFName,String expertise, string contactNo,
            ref String Response)
        {
            using (db = new AppointmentSystemEntities1())
            {
                try
                {

                    db.sp_addinstructor(instructorLName, instructorFName, expertise, contactNo);
                    Response = " Added Successfully";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public ErrorCode BOOKInstructorUsingStoredProf(int? instructorId, String instructorLName, String instructorFName, String expertise, string contactNo,
           ref String Response)
        {
            using (db = new AppointmentSystemEntities1())
            {
                try
                {

                    db.bookinsturtor(instructorId, instructorLName, instructorFName, expertise, contactNo);
                    Response = " Book Successfully";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }


        public ErrorCode UpdateInstructorUsingStoredProf(int? instructorId, String instructorLName, String instructorFName, String expertise, string contactNo,
            ref String Response)
        {
            using (db = new AppointmentSystemEntities1())
            {
                try
                {

                    db.sp_UpdateInstructor(instructorId, instructorLName, instructorFName, expertise, contactNo);
                    Response = " Update Successfully";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public ErrorCode DeleteInstructorUsingStoredProf(int? instructorId, ref String szResponse)
        {
            using (db = new AppointmentSystemEntities1())
            {
                try
                {
                    db.sp_DELETEINSTRUCTOR(instructorId);
                    szResponse = "Deleted Successfully";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    szResponse = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }
        public ErrorCode InsertCheckOUTUsingStoredProf(int?checkid, string checkfname,string checklname,string checkAddress,string checkEmail,string checkPhone,
            DateTime checkDateSTART, DateTime checkdateexpire , ref String szResponse)
         { 
             using (db = new AppointmentSystemEntities1())
            {
                try
                {
                    db.sp_checkoutBOOK(checkid, checkfname, checklname, checkAddress, checkEmail, checkPhone, checkDateSTART, checkdateexpire);
                    szResponse = "Successful!";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
    szResponse = ex.Message;
    return ErrorCode.Error;
}
            }
        }
    }
}