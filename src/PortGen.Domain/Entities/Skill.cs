using System;

namespace PortGen.Entities;

public class Skill : BaseEntity
{
    public Guid AboutId { get; set; }
    public About About { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
}