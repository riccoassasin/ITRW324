//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBTesting
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notification
    {
        public int NotificationID { get; set; }
        public int FileID { get; set; }
        public int NotificationTypeID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int UserIDOfNotificationSender { get; set; }
        public int UserIDOfNotificationRecipient { get; set; }
        public bool UserHasAcknowledgement { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual File File { get; set; }
        public virtual LookupTable_NotificationTypes LookupTable_NotificationTypes { get; set; }
    }
}
