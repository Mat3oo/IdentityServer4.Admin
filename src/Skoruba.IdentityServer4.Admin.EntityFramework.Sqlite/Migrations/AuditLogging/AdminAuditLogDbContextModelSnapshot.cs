﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Skoruba.IdentityServer4.Admin.EntityFramework.Shared.DbContexts;

#nullable disable

namespace Skoruba.IdentityServer4.Admin.EntityFramework.Sqlite.Migrations.AuditLogging
{
    [DbContext(typeof(AdminAuditLogDbContext))]
    partial class AdminAuditLogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Skoruba.AuditLogging.EntityFramework.Entities.AuditLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Action")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Event")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectAdditionalData")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectIdentifier")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AuditLog");
                });
#pragma warning restore 612, 618
        }
    }
}
