using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortGen.Abstract;
using PortGen.DTOs;
using PortGen.Entities;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace PortGen.Services;

public class SkillApplicationService : ApplicationService, ISkillApplicationService
{
    private readonly IRepository<Skill, Guid> _skillRepository;

    public SkillApplicationService(IRepository<Skill, Guid> skillRepository )=> _skillRepository = skillRepository;
    
    public void CreateSkill(SkillDto skillDto) =>   _skillRepository.InsertAsync(new Skill
    {
        Name = skillDto.Name,
        Description = skillDto.Description,
        Image = skillDto.Image
    });

    public async Task<IEnumerable<SkillDto>> GetSkillsAsync()
    {
        var skills = await _skillRepository.GetListAsync();
        
        return skills.Select(s => new SkillDto
        {
            Id = s.Id,
            Name = s.Name,
            Description = s.Description,
            Image = s.Image,
            CreationTime = s.CreationTime,
            LastModificationTime = s.LastModificationTime,
            IsDeleted = s.IsDeleted
        });
    }

    public async Task<SkillDto> UpdateSkillAsync(SkillDto dto)
    {
        var skill = await _skillRepository.FindAsync(dto.Id);
        if(skill is null) return new SkillDto();
        
        skill.Name = dto.Name;
        skill.Description = dto.Description;
        skill.Image = dto.Image;
        skill.LastModificationTime = DateTime.Now;
      var result =   await _skillRepository.UpdateAsync(skill, true);

        return new SkillDto
        {
            Id = result.Id,
            Name = result.Name,
            Description = result.Description,
            Image = result.Image,
            CreationTime = result.CreationTime,
            LastModificationTime = result.LastModificationTime,
            IsDeleted = result.IsDeleted
        };
    }

    public Task DeleteSkillAsync(Guid id)
    {
        return _skillRepository.DeleteAsync(id, true);
    }
}