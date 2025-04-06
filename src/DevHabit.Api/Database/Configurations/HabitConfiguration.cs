using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DevHabit.Api.Core.Constants;
using DevHabit.Api.Entities;

namespace DevHabit.Api.Database.Configurations;

public sealed class HabitConfiguration : IEntityTypeConfiguration<Habit>
{
    public void Configure(EntityTypeBuilder<Habit> builder)
    {
        builder.HasKey(h => h.Id);

        builder.Property(h => h.Id).HasMaxLength(DbConstants.INTEGER_LENGTH_500);

        builder.Property(h => h.Name).HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_100);

        builder.Property(h => h.Description).HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_100);

        builder.OwnsOne(h => h.Frequency);
        builder.OwnsOne(h => h.Target, targetBuilder =>
        {
            targetBuilder.Property(t => t.Unit).HasMaxLength(DbConstants.VARCHAR_STRING_LENGTH_100);
        });
        builder.OwnsOne(h => h.Milestone);
    }
}
