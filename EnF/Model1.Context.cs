﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DoGoMyNgheEntities : DbContext
    {
        public DoGoMyNgheEntities()
            : base("name=DoGoMyNgheEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADV> ADVs { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Countview> Countviews { get; set; }
        public virtual DbSet<CustommerOpinion> CustommerOpinions { get; set; }
        public virtual DbSet<ImageList> ImageLists { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductItem> ProductItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    }
}