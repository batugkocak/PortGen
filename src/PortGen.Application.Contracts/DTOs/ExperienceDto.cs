using System;

namespace PortGen.DTOs;

public class ExperienceDto : BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } // Nullable EndDate
}