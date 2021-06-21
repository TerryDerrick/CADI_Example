using CADI_Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CADI_Example.Persistance.Configuration
{
    public class TestDataConfiguration : IEntityTypeConfiguration<TestData>
    {
        /// <summary>
        /// Configures the entity of type <see cref="TestData"/>.
        /// </summary>
        /// <param name="builder">
        /// The builder to be used to configure the entity type.
        /// </param>
        public void Configure(EntityTypeBuilder<TestData> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            // Ensure table is part of dbo and name is non-pluralised.
            builder.ToTable(name: builder.Metadata.ClrType.Name, schema: "dbo");

            builder.HasKey(e => e.TestDataId);

            builder.Property(e => e.TestType)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Value1)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Value2)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.ExpectedValue)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.TestResult)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasData(new List<TestData>
            {
                new TestData { },
            });
        }
    }
}
