using DevHabit.Api.Core.Constants;
using DevHabit.Api.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DevHabit.Api.Database.Configurations;

public sealed class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id).HasMaxLength(DbConstants.INTEGER_LENGTH_500);

        builder.Property(t => t.Name).IsRequired().HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_50);

        builder.Property(t => t.Description).HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_500);

        builder.HasIndex(t => new { t.Name }).IsUnique();
    }
}
