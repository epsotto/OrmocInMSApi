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
    
    public partial class TagsMapping
    {
        public int Id { get; set; }
        public int ItemID { get; set; }
        public int TagID { get; set; }
        public bool IsActive { get; set; }
        public string CreateUserName { get; set; }
        public System.DateTime CreateDttm { get; set; }
        public string UpdateUserName { get; set; }
        public System.DateTime UpdateDttm { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
