﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BOOKCOMMUNITYEntities : DbContext
    {
        public BOOKCOMMUNITYEntities()
            : base("name=BOOKCOMMUNITYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<device> devices { get; set; }
        public virtual DbSet<episode> episodes { get; set; }
        public virtual DbSet<like> likes { get; set; }
        public virtual DbSet<moderation_book> moderation_book { get; set; }
        public virtual DbSet<moderation_episode> moderation_episode { get; set; }
        public virtual DbSet<point> points { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<usergroup> usergroups { get; set; }
    }
}