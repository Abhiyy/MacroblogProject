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
    
    public partial class State
    {
        public State()
        {
            this.UserDetails = new HashSet<UserDetail>();
        }
    
        public int StateID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
