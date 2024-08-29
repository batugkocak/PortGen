using System;
using Volo.Abp.Application.Dtos;

namespace PortGen.DTOs;

public class SkillDto : BaseDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; } 
}