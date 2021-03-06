//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDocs.DomainModels.Database
{
    using System;
    using System.Collections.Generic;
    
     using WebDocs.DomainModels.Interfaces.Entities;
    public partial class SystemTransactionLogsModel: IEntity
    {
        public int SystemTransactionLogID { get; set; }
    	
        public int SystemTransactionTypeID { get; set; }
    	
        public int UserIDThatPerformedTansaction { get; set; }
    	
        public System.DateTime DateTansactionPerformed { get; set; }
    	
        public int FileID { get; set; }
    	
        public string TransactionComments { get; set; }
    	
    		public EntityState EntityState { get; set; }
    		
        public virtual UsersModel PersonThatPerformedTransactions { get; set; }
        public virtual SystemTransactionTypesModel SystemTransactionTypes { get; set; }
        public virtual FileModel File { get; set; }
    }
}
