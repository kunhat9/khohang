//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhoHang.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_InventoryDetails
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> TotalRemaining { get; set; }
        public Nullable<int> TotalUsed { get; set; }
        public string Note { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> InventoryId { get; set; }
        public Nullable<int> TotalNow { get; set; }
    }
}
