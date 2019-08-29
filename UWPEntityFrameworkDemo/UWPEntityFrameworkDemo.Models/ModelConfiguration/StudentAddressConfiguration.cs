using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UWPEntityFrameworkDemo.Models.DataModels;

namespace UWPEntityFrameworkDemo.Models.ModelConfiguration
{
    public class StudentAddressConfiguration : IEntityTypeConfiguration<StudentAddress>
    {
        public void Configure(EntityTypeBuilder<StudentAddress> builder)
        {
            builder.ToTable("StudentAddresses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("StudentAddressID");
            

        }
    }
}
