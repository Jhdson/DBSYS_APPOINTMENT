using Final_System.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_System.Utils;

namespace Final_System.Repositories
{
    public class userRepository
    {
        private AppointmentSystemEntities db;

        public userRepository()
        {
            db = new AppointmentSystemEntities();
        }

        public tblUser GetUserByUsername(String username)
        {
            using (db = new AppointmentSystemEntities())
            {
                return db.tblUser.Where(m => m.userName == username).FirstOrDefault();

            }
        }
        public List<vw_UserTable> UserTablesTable()
        {
            using (db = new AppointmentSystemEntities())
            {
                return db.vw_UserTable.ToList();
            }
        }
        public ErrorCode InsertUserUsingStoredProf(string userFirstname, string userLastname, string usermiddleIn, string userAddress, string userEmail, string userNumber, string uusername
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
        public ErrorCode ADDUserUsingStoredProf(string userFirstname, string userLastname, string usermiddleIn, string userAddress, string userEmail, string userNumber, string uusername
            , string userpass, string Response)
        {
            using (db = new AppointmentSystemEntities())
            {
                try
                {

                    db.sp_(userLastname, userFirstname, usermiddleIn, userAddress,
                        userEmail, userNumber, uusername, userpass);
                    Response = " Added ";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {
                    Response = ex.Message;
                    return ErrorCode.Error;
                }
            }
        }


        public ErrorCode UpdateUserUsingStoredProf(int? userID, string userFirstname, string userFirstname, string usermiddleIn, string userAddress, string userEmail, string userNumber, string uusername
            , string userpass, string Response)
        {
            using (db = new AppointmentSystemEntities())
            {
                try
                {

                    db.sp_UPDATEUSER(userID, userLastname, userFirstname, usermiddleIn, userAddress,
                        userEmail, userNumber, uusername, userpass);
                    Response = " Updated ";
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
            using (db = new AppointmentSystemEntities())
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
    }
}