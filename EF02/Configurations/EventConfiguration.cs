
//using EventHub;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace EventHub.Configurations;

//public class EventConfiguration
//    : IEntityTypeConfiguration<Event>
//{
//    public void Configure(EntityTypeBuilder<Event> builder)
//    {
//        builder.HasKey(e => e.Id);

//        builder.Property(e => e.Title)
//               .IsRequired()
//               .HasMaxLength(200);

//        builder.Property(e => e.Description)
//               .IsRequired()
//               .HasMaxLength(2000);

//        builder.Property(e => e.StartDate)
//               .IsRequired();

//        builder.Property(e => e.EndDate)
//               .IsRequired(false);

//        builder.Property(e => e.MaxAttendees)
//               .IsRequired();

//        // Organizer 1 ---- * Event
//        builder.HasOne(e => e.Organizer)
//               .WithMany(o => o.Events)
//               .HasForeignKey(e => e.OrganizerId)
//               .IsRequired()
//               .OnDelete(DeleteBehavior.Cascade);
//    }
//}
