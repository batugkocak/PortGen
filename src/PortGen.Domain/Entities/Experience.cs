namespace PortGen.Entities;

using System;

public class Experience : BaseEntity 
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } 
}

