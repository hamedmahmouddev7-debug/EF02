
//using EventHub.Configurations;
//using Microsoft.EntityFrameworkCore;
//using System.Reflection.Emit;

//namespace EventHub;

//public class EventHubContext : DbContext
//{
//    public DbSet<Organizer> Organizers => Set<Organizer>();
//    public DbSet<OrganizerProfile> OrganizerProfiles => Set<OrganizerProfile>();
//    public DbSet<Event> Events => Set<Event>();
//    public DbSet<Attendee> Attendees => Set<Attendee>();
//    public DbSet<Badge> Badges => Set<Badge>();

//    protected override void OnConfiguring(
//        DbContextOptionsBuilder options)
//    {
//        options.UseSqlServer(
//            "Server=.;Database=EventHubDb;Trusted_Connection=True;TrustServerCertificate=True");
//    }

//    protected override void OnModelCreating(
//        ModelBuilder modelBuilder)
//    {
//        // OrganizerProfile Configuration
//        modelBuilder.Entity<OrganizerProfile>(b =>
//        {
//            b.HasKey(p => p.Id);

//            b.Property(p => p.Biography)
//             .HasMaxLength(1000);

//            b.Property(p => p.WebsiteUrl)
//             .HasMaxLength(300);

//            b.Property(p => p.LogoUrl)
//             .HasMaxLength(500);

//            // Organizer 1 ---- 0..1 OrganizerProfile
//            b.HasOne(p => p.Organizer)
//             .WithOne(o => o.Profile)
//             .HasForeignKey<OrganizerProfile>(
//                 p => p.OrganizerId)
//             .IsRequired()
//             .OnDelete(DeleteBehavior.Cascade);
//        });

//        // Separate Configuration Classes
//        modelBuilder.ApplyConfiguration(
//            new EventConfiguration());

//        modelBuilder.ApplyConfiguration(
//            new BadgeConfiguration());
//    }
//}
