using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication11CRUD.Models;

//контекст базы данных (сгенерирован пакетом EntityFrameworkCore.Tools)
public partial class CompanyDbContext : DbContext
{
    public CompanyDbContext()
    {
    }

    public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11D0A4182E");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.JoiningDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
