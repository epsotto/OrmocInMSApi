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
    
    public partial class ItemRequestFormSearch_SP_Result
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int StatusCd { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> FollowupStartDttm { get; set; }
        public string CreateUserName { get; set; }
        public System.DateTime CreateDttm { get; set; }
        public string UpdateUserName { get; set; }
        public System.DateTime UpdateDttm { get; set; }
        public string CodeValue { get; set; }
        public string TicketStatus { get; set; }
    }
}