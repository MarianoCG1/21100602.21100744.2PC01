using System;
using System.Collections.Generic;

namespace _21100602._21100744._2PC01.Entities;

public partial class Attendees
{
    public int Id { get; set; }

    public string AttendeeName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateTime? RegisteredAt { get; set; }

    public virtual ICollection<EventAttendance> EventAttendance { get; set; } = new List<EventAttendance>();
}
