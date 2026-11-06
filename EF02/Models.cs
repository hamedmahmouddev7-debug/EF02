
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHub;

public enum BadgeTier
{
    Standard,
    VIP
}

// Data Annotations
[Table("EventOrganizers")]
public class Organizer
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(150)]
    public string? CompanyName { get; set; }

    public bool IsVerified { get; set; }

    public OrganizerProfile? Profile { get; set; }

    public ICollection<Event> Events { get; set; }
        = new List<Event>();
}

public class Attendee
{
    public int Id { get; set; }

    [Required, MaxLength(150)]
    public string FullName { get; set; } = string.Empty;

    [Required, MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    [Required, MaxLength(150)]
    public string Street { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string City { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string Country { get; set; } = string.Empty;

    [Required, MaxLength(20), Column("ZipCode")]
    public string PostalCode { get; set; } = string.Empty;

    [NotMapped]
    public string FullAddress =>
        $"{Street}, {City}, {Country}, {PostalCode}";

    public Badge? Badge { get; set; }
}

// Fluent API داخل OnModelCreating
public class OrganizerProfile
{
    public int Id { get; set; }

    public string? Biography { get; set; }
    public string? WebsiteUrl { get; set; }
    public string? LogoUrl { get; set; }

    public int OrganizerId { get; set; }

    public Organizer Organizer { get; set; } = null!;
}

// Fluent API في Configuration Classes
public class Event
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public int MaxAttendees { get; set; }

    public int OrganizerId { get; set; }
    public Organizer Organizer { get; set; } = null!;
}

public class Badge
{
    public int Id { get; set; }

    public int BadgeNumber { get; set; }
    public DateTime IssuedDate { get; set; }

    public BadgeTier Tier { get; set; }

    public int AttendeeId { get; set; }
    public Attendee Attendee { get; set; } = null!;
}
