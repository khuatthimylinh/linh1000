//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blog.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Action
    {
       
        public string Username { get; set; }
        public int BlogId { get; set; }
        public Nullable<bool> Vote { get; set; }
        public Nullable<bool> Report { get; set; }
        public Nullable<int> View { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Blog Blog { get; set; }
    }
}