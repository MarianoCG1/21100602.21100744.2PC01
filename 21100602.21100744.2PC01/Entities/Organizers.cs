using System;
using System.Collections.Generic;

namespace _21100602._21100744._2PC01.Entities;

public partial class Organizers
{
    public int Id { get; set; }

    public string OrganizerName { get; set; } = null!;

    public string ContactEmail { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Events> Events { get; set; } = new List<Events>();
}
