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
    public partial class CategoriesModel: IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoriesModel()
        {
            this.FileCategories = new HashSet<FileCategoryModel>();
        }
    
        public int LookupTableFileCategoryID { get; set; }
    	
        public string FileCategory { get; set; }
    	
    		public EntityState EntityState { get; set; }
    		
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileCategoryModel> FileCategories { get; set; }
    }
}
