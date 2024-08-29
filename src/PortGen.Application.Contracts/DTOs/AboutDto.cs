using System;

namespace PortGen.DTOs;

public class AboutDto : BaseDto
{
    public Guid Id { get; set; } 
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Information { get; set; }
}