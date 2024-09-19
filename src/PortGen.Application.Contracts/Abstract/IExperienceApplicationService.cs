using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortGen.DTOs;
using Volo.Abp.Application.Services;

namespace PortGen.Abstract;

public interface IExperienceApplicationService : IApplicationService
{
    public void CreateExperience(ExperienceDto ExperienceDto);
    public Task<IEnumerable<ExperienceDto>> GetExperiencesAsync(Guid aboutId);
    
    public Task<ExperienceDto> UpdateExperienceAsync(ExperienceDto ExperienceDto);
    
    public Task DeleteExperienceAsync(Guid id);
}