using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Domain.Models.User
{
    public class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T :class
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            var nonPublicProperties = builder.Metadata.ClrType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var p in nonPublicProperties)
            {
                builder.Property(p.Name);
            }
        }
    }
}
