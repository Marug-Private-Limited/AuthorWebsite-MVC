//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace authorrenjusridhar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class author_blogcomments
    {
        public int userid { get; set; }
        public string comment_title { get; set; }
        public string username { get; set; }
        public string useremail { get; set; }
        public string usercomments { get; set; }
        public Nullable<System.DateTime> commented_on { get; set; }
    }
}