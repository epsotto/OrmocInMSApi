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
    
    public partial class PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrder()
        {
            this.PurchaseOrderMappings = new HashSet<PurchaseOrderMapping>();
        }
    
        public int Id { get; set; }
        public Nullable<int> QuotationID { get; set; }
        public string Title { get; set; }
        public int SupplierID { get; set; }
        public int StatusCd { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public string CreateUserName { get; set; }
        public System.DateTime CreateDttm { get; set; }
        public string UpdateUserName { get; set; }
        public System.DateTime UpdateDttm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderMapping> PurchaseOrderMappings { get; set; }
        public virtual Quotation Quotation { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual CodeDetail CodeDetail { get; set; }
    }
}
