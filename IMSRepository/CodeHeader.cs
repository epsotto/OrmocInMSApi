//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMSRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class CodeHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodeHeader()
        {
            this.CodeDetails = new HashSet<CodeDetail>();
        }
    
        public int Id { get; set; }
        public string CodeHeaderName { get; set; }
        public bool IsActive { get; set; }
        public string CreateUserName { get; set; }
        public System.DateTime CreateDttm { get; set; }
        public string UpdateUserName { get; set; }
        public System.DateTime UpdateDttm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodeDetail> CodeDetails { get; set; }
    }
}