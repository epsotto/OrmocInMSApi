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
    
    public partial class Quotation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quotation()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.QuotationsMappings = new HashSet<QuotationsMapping>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IRFID { get; set; }
        public string Title { get; set; }
        public int StatusCd { get; set; }
        public int SupplierID { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> FollowupStartDttm { get; set; }
        public bool IsActive { get; set; }
        public string CreateUserName { get; set; }
        public System.DateTime CreateDttm { get; set; }
        public string UpdateUserName { get; set; }
        public System.DateTime UpdateDttm { get; set; }
    
        public virtual CodeDetail CodeDetail { get; set; }
        public virtual ItemRequestForm ItemRequestForm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotationsMapping> QuotationsMappings { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
