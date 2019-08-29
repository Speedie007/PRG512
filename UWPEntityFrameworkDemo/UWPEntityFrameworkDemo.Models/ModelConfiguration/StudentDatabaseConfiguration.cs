using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UWPEntityFrameworkDemo.Models.DataModels;

namespace UWPEntityFrameworkDemo.Models.ModelConfiguration
{
    public class StudentDatabaseConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("StudentID");


            builder.Property(t => t.DateOfBirth)
                    .IsRequired()
                    .HasColumnType("Date")
                    .HasDefaultValueSql("GetDate()");

            builder
                .HasMany(c => c.StudentAddresses)
                .WithOne(e => e.Student)
                .IsRequired();

        }
    }
}
