//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA.AppBanwao.Blog.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLogin
    {
        public long LoginID { get; set; }
        public Nullable<long> UserID { get; set; }
        public string Token { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public Nullable<System.DateTime> ActiveTill { get; set; }
        public Nullable<System.DateTime> ActualLogOut { get; set; }
    }
}