using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactPro.Models
{
    public class ContactProDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx


        public ContactProDB() : base("DefaultConnection")
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUserName = !string.IsNullOrEmpty(System.Web.HttpContext.Current?.User?.Identity.Name)
                ? HttpContext.Current.User.Identity.Name
                : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).DateAdded = DateTime.Now;
                    ((BaseEntity)entity.Entity).AddedBy = currentUserName;
                    ((BaseEntity)entity.Entity).LastModified = null;
                    ((BaseEntity)entity.Entity).LastModifiedBy = null;
                }
                else if (entity.State == EntityState.Modified)
                {
                    ((BaseEntity)entity.Entity).LastModified= DateTime.Now;
                    ((BaseEntity)entity.Entity).LastModifiedBy = currentUserName;
                }
                    
                // ((BaseEntity)entity.Entity).DateModified = DateTime.Now;
                // ((BaseEntity)entity.Entity).UserModified = currentUserName;
            }
        }
    }
}
