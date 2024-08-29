using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace PortGen.Entities;

public class BaseEntity : FullAuditedAggregateRoot<Guid>
{

}