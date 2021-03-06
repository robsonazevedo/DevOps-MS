﻿using Domain.Entities;
using Repository.EntityConfig;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Repository.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base(ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ToString()) { }

        public DbSet<BookEntity> Books { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name.Equals("Id", System.StringComparison.CurrentCultureIgnoreCase))
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(256));

            modelBuilder.Properties<DateTime>()
                .Where(p => p.Name.Equals("DateInsert", StringComparison.CurrentCultureIgnoreCase))
                .Configure(p => p.IsRequired());

            modelBuilder.Properties<DateTime>()
               .Where(p => p.Name.Equals("IsTest", StringComparison.CurrentCultureIgnoreCase))
               .Configure(p => p.IsRequired());

            var bookConfig = new BookEntityConfiguration();
            var categoryConfig = new CategoryEntityConfiguration();

            modelBuilder.Configurations.Add(bookConfig);
            modelBuilder.Configurations.Add(categoryConfig);

            modelBuilder.Entity<BookEntity>()
              .HasMany(b => b.Categories)
              .WithMany(c => c.Books)
              .Map(cs =>
              {
                  cs.MapLeftKey("BookId");
                  cs.MapRightKey("CategoryId");
                  cs.ToTable("BookCategory");
              });
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("DateInsert") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateInsert").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateInsert").IsModified = false;
                    entry.Property("DateUpdate").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}


