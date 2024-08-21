using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Crud.Models;

namespace Crud.Data
{
    public partial class KABABJESContext : DbContext
    {
        public KABABJESContext()
        {
        }

        public KABABJESContext(DbContextOptions<KABABJESContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserAccount> UserAccounts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
        =>    optionsBuilder.UseSqlServer();
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.ToTable("User_Account");

                entity.HasIndex(e => e.Useremail, "UQ__User_Acc__61CED930ED662711")
                    .IsUnique();

                entity.Property(e => e.UserDasignation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USER_DASIGNATION");

                entity.Property(e => e.UserResume)
                    .IsUnicode(false)
                    .HasColumnName("USER_RESUME");

                entity.Property(e => e.Useremail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USEREMAIL");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
