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

public class ExperienceApplicationService : ApplicationService, IExperienceApplicationService
{
    private readonly IRepository<Experience, Guid> _repository;

    public ExperienceApplicationService(IRepository<Experience, Guid> repository) => _repository = repository;


    public void CreateExperience(ExperienceDto experienceDto) => _repository.InsertAsync(new Experience
    {
        Description = experienceDto.Description,
        Title = experienceDto.Title,
        StartDate = experienceDto.StartDate,
        EndDate = experienceDto.EndDate
    });

    public async Task<IEnumerable<ExperienceDto>> GetExperiencesAsync()
    {
        var experiences = await _repository.GetListAsync();

        return experiences.Select(s => new ExperienceDto
        {
            Id = s.Id,
            Description = s.Description,
            Title = s.Title,
            StartDate = s.StartDate,
            EndDate = s.EndDate,
            CreationTime = s.CreationTime,
            LastModificationTime = s.LastModificationTime,
            IsDeleted = s.IsDeleted
        });
    }

    public async Task<ExperienceDto> UpdateExperienceAsync(ExperienceDto request)
    {
        var experience = await _repository.FindAsync(request.Id);

        if (experience is null) return new ExperienceDto();

        experience.Description = request.Description;
        experience.Title = request.Title;
        experience.StartDate = request.StartDate;
        experience.EndDate = request.EndDate;

        var result = await _repository.UpdateAsync(experience, true);

        return new ExperienceDto
        {
            Id = result.Id,
            Description = result.Description,
            Title = result.Title,
            StartDate = result.StartDate,
            EndDate = result.EndDate,
            CreationTime = result.CreationTime,
            LastModificationTime = result.LastModificationTime,
        };
    }

    public Task DeleteExperienceAsync(Guid id) => _repository.DeleteAsync(id, true);
}