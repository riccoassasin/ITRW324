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
    public partial class FileArchiveBlobModel: IEntity
    {
        public int FileArchiveID { get; set; }
    	
        public byte[] FileImage { get; set; }
    	
    		public EntityState EntityState { get; set; }
    		
        public virtual FileArchiveModel FileArchive { get; set; }
    }
}
