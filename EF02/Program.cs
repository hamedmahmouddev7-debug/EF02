
//using EventHub;
//using Microsoft.EntityFrameworkCore;

//using var context = new EventHubContext();

//// Apply migrations
//context.Database.Migrate();

//// Insert sample data only once
//if (!context.Organizers.Any() &&
//    !context.Attendees.Any())
//{
//    var organizer = new Organizer
//    {
//        Name = "Ahmed Samy",
//        CompanyName = "TechTalks Co.",
//        IsVerified = true
//    };

//    organizer.Profile = new OrganizerProfile
//    {
//        Biography = "We run tech meetups.",
//        WebsiteUrl = "https://techtalks.example",
//        LogoUrl = "https://techtalks.example/logo.png"
//    };

//    organizer.Events.Add(new Event
//    {
//        Title = "EF Core Workshop",
//        Description = "Hands-on EF Core",
//        StartDate = DateTime.Today.AddDays(14),
//        MaxAttendees = 100
//    });

//    var attendee = new Attendee
//    {
//        FullName = "Mona Ali",
//        Email = "mona@mail.com",
//        Street = "12 Tahrir St",
//        City = "Cairo",
//        Country = "Egypt",
//        PostalCode = "11511",

//        Badge = new Badge
//        {
//            BadgeNumber = 1001,
//            IssuedDate = DateTime.Today,
//            Tier = BadgeTier.VIP
//        }
//    };

//    context.AddRange(organizer, attendee);

//    context.SaveChanges();
//}

//// Display results
//var savedOrganizer = context.Organizers
//    .Include(o => o.Profile)
//    .First();

//var savedAttendee = context.Attendees
//    .Include(a => a.Badge)
//    .First();

//Console.WriteLine(
//    $"Organizer #{savedOrganizer.Id}, " +
//    $"profile #{savedOrganizer.Profile!.Id}");

//Console.WriteLine(
//    $"Attendee #{savedAttendee.Id}: " +
//    $"{savedAttendee.FullAddress} | " +
//    $"Badge {savedAttendee.Badge!.BadgeNumber} " +
//    $"({savedAttendee.Badge.Tier})");
