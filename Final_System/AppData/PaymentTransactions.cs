//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PaymentTransactions
    {
        public int transaction_id { get; set; }
        public Nullable<int> session_id { get; set; }
        public Nullable<int> participant_id { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string payment_method { get; set; }
    
        public virtual FitnessTrainingSessions FitnessTrainingSessions { get; set; }
        public virtual Participants Participants { get; set; }
    }
}