﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UWPEntityFrameworkDemo.Models.DatabaseContext;

namespace UWPEntityFrameworkDemo.Models.Migrations
{
    [DbContext(typeof(UWPEFDemoDbContext))]
    partial class UWPEFDemoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UWPEntityFrameworkDemo.Models.DataModels.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UWPEntityFrameworkDemo.Models.DataModels.StudentAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StudentAddressID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AreaCode");

                    b.Property<string>("City");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAddresses");
                });

            modelBuilder.Entity("UWPEntityFrameworkDemo.Models.DataModels.StudentAddress", b =>
                {
                    b.HasOne("UWPEntityFrameworkDemo.Models.DataModels.Student", "Student")
                        .WithMany("StudentAddresses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
