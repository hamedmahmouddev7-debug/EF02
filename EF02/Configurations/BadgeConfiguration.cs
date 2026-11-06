
//using EventHub;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace EventHub.Configurations;

//public class BadgeConfiguration
//    : IEntityTypeConfiguration<Badge>
//{
//    public void Configure(EntityTypeBuilder<Badge> builder)
//    {
//        builder.HasKey(b => b.Id);

//        builder.Property(b => b.BadgeNumber)
//               .IsRequired();

//        builder.HasIndex(b => b.BadgeNumber)
//               .IsUnique();

//        builder.Property(b => b.IssuedDate)
//               .IsRequired();

//        builder.Property(b => b.Tier)
//               .IsRequired()
//               .HasConversion<string>()
//               .HasMaxLength(20);

//        // Attendee 1 ---- 0..1 Badge
//        builder.HasOne(b => b.Attendee)
//               .WithOne(a => a.Badge)
//               .HasForeignKey<Badge>(b => b.AttendeeId)
//               .IsRequired()
//               .OnDelete(DeleteBehavior.Cascade);
//    }
//}
