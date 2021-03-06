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
    
    public partial class File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public File()
        {
            this.FileCategories = new HashSet<FileCategory>();
            this.FileSharedWithUsers = new HashSet<FileSharedWithUser>();
            this.Notifications = new HashSet<Notification>();
        }
    
        public int FileID { get; set; }
        public int ParentFileID { get; set; }
        public int UserIDOfFileOwner { get; set; }
        public int UserIDOfLastUploaded { get; set; }
        public int FileLookupStatusID { get; set; }
        public int FileShareStatusID { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }
        public int CurrentVersionNumber { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual FileBlob FileBlob { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileCategory> FileCategories { get; set; }
        public virtual LookupTable_FileViewStatuses LookupTable_FileViewStatuses { get; set; }
        public virtual LookupTable_FileShareStatues LookupTable_FileShareStatues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileSharedWithUser> FileSharedWithUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual UserThatDownloadedFile UserThatDownloadedFile { get; set; }
    }
}
