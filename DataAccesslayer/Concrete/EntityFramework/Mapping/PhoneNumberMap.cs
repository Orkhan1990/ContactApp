using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesslayer.EntityFramework.Mapping
{
    public class PhoneNumberMap : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
         // builder.Property(i => i.NumberType).HasConversion(c => c.ToString(), c => Enum.Parse<NumberType>(c));

            builder.Property(i => i.MobilNumber).HasMaxLength(15);
            builder.Property(i => i.HomeNumber).HasMaxLength(15);
            builder.Property(i => i.WorkNumber).HasMaxLength(15);

            builder.HasOne(i => i.Contact).WithMany(i => i.PhoneNumbers).HasForeignKey(i => i.ContactId);

        }
    }
}
