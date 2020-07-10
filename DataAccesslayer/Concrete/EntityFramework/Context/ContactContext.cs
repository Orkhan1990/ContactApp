using DataAccesslayer.EntityFramework.Mapping;
using EntitiesLayer;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccesslayer.EntityFramework.Context
{
   public class ContactContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LMSM10L\MSSQLSERVER01;Database=ContactListDB;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new PhoneNumberMap());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContactContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<PhoneNumber>PhoneNumbers { get; set; }
        //public override int SaveChanges()
        //{
        //    var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));
        //    foreach (var item in entries)
        //    {
        //        ((BaseEntity)item.Entity).LastModifiedDate = DateTime.Now;
        //        if (item.State==EntityState.Added)
        //        {
        //            ((BaseEntity)item.Entity).CreatedDate = DateTime.Now;
        //        }
        //    }
        //    return base.SaveChanges();
        //}

    }
}
