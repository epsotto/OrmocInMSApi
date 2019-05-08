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
    
    public partial class CodeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodeDetail()
        {
            this.ItemRequestForms = new HashSet<ItemRequestForm>();
            this.Items = new HashSet<Item>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.Quotations = new HashSet<Quotation>();
        }
    
        public int Id { get; set; }
        public string CodeValue { get; set; }
        public int CodeHeaderId { get; set; }
        public string CodeDesc { get; set; }
        public bool IsActive { get; set; }
        public string CreateUserName { get; set; }
        public System.DateTime CreateDttm { get; set; }
        public string UpdateUserName { get; set; }
        public System.DateTime UpdateDttm { get; set; }
    
        public virtual CodeHeader CodeHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRequestForm> ItemRequestForms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quotation> Quotations { get; set; }
    }
}
