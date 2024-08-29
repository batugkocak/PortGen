using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace PortGen.Entities;

public class About : BaseEntity
{
    public Guid Id { get; set; } 
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Information { get; set; }
    public List<Skill> Skills { get; set; } = new List<Skill>(); 
    public List<Experience> Experiences { get; set; } = new List<Experience>();
    
}