﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class renju_sridharEntities5 : DbContext
    {
        public renju_sridharEntities5()
            : base("name=renju_sridharEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<author_blog> author_blog { get; set; }
        public virtual DbSet<author_blogcomments> author_blogcomments { get; set; }
        public virtual DbSet<author_books> author_books { get; set; }
        public virtual DbSet<author_userprofile> author_userprofile { get; set; }
        public virtual DbSet<subscriber> subscribers { get; set; }
    }
}