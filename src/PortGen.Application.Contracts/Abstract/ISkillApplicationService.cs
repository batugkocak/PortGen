using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortGen.DTOs;
using Volo.Abp.Application.Services;

namespace PortGen.Abstract;

public interface ISkillApplicationService : IApplicationService
{
    public void CreateSkill(SkillDto skillDto);
    public Task<IEnumerable<SkillDto>> GetSkillsAsync(Guid id);
    public Task<SkillDto> UpdateSkillAsync(SkillDto skillDto);
    public Task DeleteSkillAsync(Guid id);
}