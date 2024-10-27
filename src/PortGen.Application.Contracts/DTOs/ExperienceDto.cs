using System;

namespace PortGen.DTOs;

public class ExperienceDto : BaseDto
{
    public Guid AboutId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int OrderNo { get; set; }
    public string StartDate { get; set; }
    public string? EndDate { get; set; } // Nullable EndDate
}