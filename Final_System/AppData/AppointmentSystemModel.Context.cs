﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_System.AppData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class AppointmentSystemEntities : DbContext
    {
        public AppointmentSystemEntities()
            : base("name=AppointmentSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<checkoutBOOK> checkoutBOOKs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TblInstructor> TblInstructors { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<vw_InsTable> vw_InsTable { get; set; }
        public DbSet<vw_TrainingTable> vw_TrainingTable { get; set; }
        public DbSet<vw_UserTable> vw_UserTable { get; set; }
        public DbSet<vw_allAppointment> vw_allAppointment { get; set; }
        public DbSet<vw_INstaffBook> vw_INstaffBook { get; set; }
    
        public virtual int sp_addinstructor(string instructorLName, string instructorFName, string expertise, string contactNo)
        {
            var instructorLNameParameter = instructorLName != null ?
                new ObjectParameter("instructorLName", instructorLName) :
                new ObjectParameter("instructorLName", typeof(string));
    
            var instructorFNameParameter = instructorFName != null ?
                new ObjectParameter("instructorFName", instructorFName) :
                new ObjectParameter("instructorFName", typeof(string));
    
            var expertiseParameter = expertise != null ?
                new ObjectParameter("expertise", expertise) :
                new ObjectParameter("expertise", typeof(string));
    
            var contactNoParameter = contactNo != null ?
                new ObjectParameter("contactNo", contactNo) :
                new ObjectParameter("contactNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_addinstructor", instructorLNameParameter, instructorFNameParameter, expertiseParameter, contactNoParameter);
        }
    
        public virtual int sp_checkoutBOOK(Nullable<int> checkid, string checkfname, string checklname, string checkAddress, string checkEmail, string checkPhone, Nullable<System.DateTime> checkDateSTART, Nullable<System.DateTime> checkDateEXPIRE)
        {
            var checkidParameter = checkid.HasValue ?
                new ObjectParameter("checkid", checkid) :
                new ObjectParameter("checkid", typeof(int));
    
            var checkfnameParameter = checkfname != null ?
                new ObjectParameter("checkfname", checkfname) :
                new ObjectParameter("checkfname", typeof(string));
    
            var checklnameParameter = checklname != null ?
                new ObjectParameter("checklname", checklname) :
                new ObjectParameter("checklname", typeof(string));
    
            var checkAddressParameter = checkAddress != null ?
                new ObjectParameter("checkAddress", checkAddress) :
                new ObjectParameter("checkAddress", typeof(string));
    
            var checkEmailParameter = checkEmail != null ?
                new ObjectParameter("checkEmail", checkEmail) :
                new ObjectParameter("checkEmail", typeof(string));
    
            var checkPhoneParameter = checkPhone != null ?
                new ObjectParameter("checkPhone", checkPhone) :
                new ObjectParameter("checkPhone", typeof(string));
    
            var checkDateSTARTParameter = checkDateSTART.HasValue ?
                new ObjectParameter("checkDateSTART", checkDateSTART) :
                new ObjectParameter("checkDateSTART", typeof(System.DateTime));
    
            var checkDateEXPIREParameter = checkDateEXPIRE.HasValue ?
                new ObjectParameter("checkDateEXPIRE", checkDateEXPIRE) :
                new ObjectParameter("checkDateEXPIRE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_checkoutBOOK", checkidParameter, checkfnameParameter, checklnameParameter, checkAddressParameter, checkEmailParameter, checkPhoneParameter, checkDateSTARTParameter, checkDateEXPIREParameter);
        }
    
        public virtual int sp_DELETEINSTRUCTOR(Nullable<int> instructorId)
        {
            var instructorIdParameter = instructorId.HasValue ?
                new ObjectParameter("instructorId", instructorId) :
                new ObjectParameter("instructorId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DELETEINSTRUCTOR", instructorIdParameter);
        }
    
        public virtual int sp_deleteUSER(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteUSER", userIDParameter);
        }
    
        public virtual int sp_InsertUser(string userFirstname, string userLastname, string usermiddleIn, string userAddress, string userEmail, string userNumber, string uusername, string userpass)
        {
            var userFirstnameParameter = userFirstname != null ?
                new ObjectParameter("userFirstname", userFirstname) :
                new ObjectParameter("userFirstname", typeof(string));
    
            var userLastnameParameter = userLastname != null ?
                new ObjectParameter("userLastname", userLastname) :
                new ObjectParameter("userLastname", typeof(string));
    
            var usermiddleInParameter = usermiddleIn != null ?
                new ObjectParameter("usermiddleIn", usermiddleIn) :
                new ObjectParameter("usermiddleIn", typeof(string));
    
            var userAddressParameter = userAddress != null ?
                new ObjectParameter("userAddress", userAddress) :
                new ObjectParameter("userAddress", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("userEmail", userEmail) :
                new ObjectParameter("userEmail", typeof(string));
    
            var userNumberParameter = userNumber != null ?
                new ObjectParameter("userNumber", userNumber) :
                new ObjectParameter("userNumber", typeof(string));
    
            var uusernameParameter = uusername != null ?
                new ObjectParameter("Uusername", uusername) :
                new ObjectParameter("Uusername", typeof(string));
    
            var userpassParameter = userpass != null ?
                new ObjectParameter("userpass", userpass) :
                new ObjectParameter("userpass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertUser", userFirstnameParameter, userLastnameParameter, usermiddleInParameter, userAddressParameter, userEmailParameter, userNumberParameter, uusernameParameter, userpassParameter);
        }
    
        public virtual int sp_INSERTUSERr(Nullable<int> userId, string userFirstname, string userLastname, string usermiddleIn, string userAddress, string userEmail, string userNumber, string uusername, string userpass)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var userFirstnameParameter = userFirstname != null ?
                new ObjectParameter("userFirstname", userFirstname) :
                new ObjectParameter("userFirstname", typeof(string));
    
            var userLastnameParameter = userLastname != null ?
                new ObjectParameter("userLastname", userLastname) :
                new ObjectParameter("userLastname", typeof(string));
    
            var usermiddleInParameter = usermiddleIn != null ?
                new ObjectParameter("usermiddleIn", usermiddleIn) :
                new ObjectParameter("usermiddleIn", typeof(string));
    
            var userAddressParameter = userAddress != null ?
                new ObjectParameter("userAddress", userAddress) :
                new ObjectParameter("userAddress", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("userEmail", userEmail) :
                new ObjectParameter("userEmail", typeof(string));
    
            var userNumberParameter = userNumber != null ?
                new ObjectParameter("userNumber", userNumber) :
                new ObjectParameter("userNumber", typeof(string));
    
            var uusernameParameter = uusername != null ?
                new ObjectParameter("Uusername", uusername) :
                new ObjectParameter("Uusername", typeof(string));
    
            var userpassParameter = userpass != null ?
                new ObjectParameter("userpass", userpass) :
                new ObjectParameter("userpass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_INSERTUSERr", userIdParameter, userFirstnameParameter, userLastnameParameter, usermiddleInParameter, userAddressParameter, userEmailParameter, userNumberParameter, uusernameParameter, userpassParameter);
        }
    
        public virtual int sp_UpdateInstructor(Nullable<int> instructorId, string instructorLName, string instructorFName, string expertise, string contactNo)
        {
            var instructorIdParameter = instructorId.HasValue ?
                new ObjectParameter("instructorId", instructorId) :
                new ObjectParameter("instructorId", typeof(int));
    
            var instructorLNameParameter = instructorLName != null ?
                new ObjectParameter("instructorLName", instructorLName) :
                new ObjectParameter("instructorLName", typeof(string));
    
            var instructorFNameParameter = instructorFName != null ?
                new ObjectParameter("instructorFName", instructorFName) :
                new ObjectParameter("instructorFName", typeof(string));
    
            var expertiseParameter = expertise != null ?
                new ObjectParameter("expertise", expertise) :
                new ObjectParameter("expertise", typeof(string));
    
            var contactNoParameter = contactNo != null ?
                new ObjectParameter("contactNo", contactNo) :
                new ObjectParameter("contactNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateInstructor", instructorIdParameter, instructorLNameParameter, instructorFNameParameter, expertiseParameter, contactNoParameter);
        }
    
        public virtual int sp_UPDATEUSER(Nullable<int> userID, string userLastname, string userFirstname, string usermiddleIn, string userAddress, string userEmail, string userNumber, string uusername, string userpass)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var userLastnameParameter = userLastname != null ?
                new ObjectParameter("userLastname", userLastname) :
                new ObjectParameter("userLastname", typeof(string));
    
            var userFirstnameParameter = userFirstname != null ?
                new ObjectParameter("userFirstname", userFirstname) :
                new ObjectParameter("userFirstname", typeof(string));
    
            var usermiddleInParameter = usermiddleIn != null ?
                new ObjectParameter("usermiddleIn", usermiddleIn) :
                new ObjectParameter("usermiddleIn", typeof(string));
    
            var userAddressParameter = userAddress != null ?
                new ObjectParameter("userAddress", userAddress) :
                new ObjectParameter("userAddress", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("userEmail", userEmail) :
                new ObjectParameter("userEmail", typeof(string));
    
            var userNumberParameter = userNumber != null ?
                new ObjectParameter("userNumber", userNumber) :
                new ObjectParameter("userNumber", typeof(string));
    
            var uusernameParameter = uusername != null ?
                new ObjectParameter("Uusername", uusername) :
                new ObjectParameter("Uusername", typeof(string));
    
            var userpassParameter = userpass != null ?
                new ObjectParameter("userpass", userpass) :
                new ObjectParameter("userpass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UPDATEUSER", userIDParameter, userLastnameParameter, userFirstnameParameter, usermiddleInParameter, userAddressParameter, userEmailParameter, userNumberParameter, uusernameParameter, userpassParameter);
        }
    
        public virtual int bookinsturtor(Nullable<int> insID, string insFN, string insLN, string insEXPER, string insPHONE)
        {
            var insIDParameter = insID.HasValue ?
                new ObjectParameter("insID", insID) :
                new ObjectParameter("insID", typeof(int));
    
            var insFNParameter = insFN != null ?
                new ObjectParameter("insFN", insFN) :
                new ObjectParameter("insFN", typeof(string));
    
            var insLNParameter = insLN != null ?
                new ObjectParameter("insLN", insLN) :
                new ObjectParameter("insLN", typeof(string));
    
            var insEXPERParameter = insEXPER != null ?
                new ObjectParameter("insEXPER", insEXPER) :
                new ObjectParameter("insEXPER", typeof(string));
    
            var insPHONEParameter = insPHONE != null ?
                new ObjectParameter("insPHONE", insPHONE) :
                new ObjectParameter("insPHONE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("bookinsturtor", insIDParameter, insFNParameter, insLNParameter, insEXPERParameter, insPHONEParameter);
        }
    }
}
