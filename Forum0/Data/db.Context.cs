﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbContainer : DbContext
    {
        public dbContainer()
            : base("name=dbContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> UserSet { get; set; }
        public virtual DbSet<UserType> UserTypeSet { get; set; }
        public virtual DbSet<Post> PostSet { get; set; }
        public virtual DbSet<Category> CategorySet { get; set; }
        public virtual DbSet<Comment> CommentSet { get; set; }
        public virtual DbSet<Log> LogSet { get; set; }
    }
}