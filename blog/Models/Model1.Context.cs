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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BlogDataEntities1 : DbContext
    {
        public BlogDataEntities1()
            : base("name=BlogDataEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountActivation> AccountActivation { get; set; }
        public virtual DbSet<AccountResetPass> AccountResetPass { get; set; }
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
