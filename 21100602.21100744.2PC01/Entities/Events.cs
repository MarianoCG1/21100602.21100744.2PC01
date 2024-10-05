using System;
using System.Collections.Generic;

namespace _21100602._21100744._2PC01.Entities;

public partial class Events
{
    public int Id { get; set; }

    public int? OrganizerId { get; set; }

    public string EventName { get; set; } = null!;

    public DateTime EventDate { get; set; }

    public string Location { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<EventAttendance> EventAttendance { get; set; } = new List<EventAttendance>();

    public virtual Organizers? Organizer { get; set; }
}
