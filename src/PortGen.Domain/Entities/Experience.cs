namespace PortGen.Entities;

using System;

public class Experience : BaseEntity 
{
    public Guid AboutId { get; set; }
    public About About { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } 
}

