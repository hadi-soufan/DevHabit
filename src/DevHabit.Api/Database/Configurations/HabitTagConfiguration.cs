using DevHabit.Api.Core.Constants;
using DevHabit.Api.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DevHabit.Api.Database.Configurations;

public sealed class HabitTagConfiguration : IEntityTypeConfiguration<HabitTag>
{
    public void Configure(EntityTypeBuilder<HabitTag> builder)
    {
        builder.HasKey(ht => new { ht.HabitId, ht.TagId });

        builder.Property(h => h.HabitId).HasMaxLength(DbConstants.INTEGER_LENGTH_500);
        builder.Property(h => h.TagId).HasMaxLength(DbConstants.INTEGER_LENGTH_500);

        builder.HasOne<Tag>()
            .WithMany()
            .HasForeignKey(ht => ht.TagId);

        builder.HasOne<Habit>()
            .WithMany(h => h.HabitTags)
            .HasForeignKey(ht => ht.HabitId);
    }
}
