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


    public void CreateExperience(ExperienceDto experienceDto)
    {
        try
        {
            _repository.InsertAsync(new Experience
            {
                AboutId = experienceDto.AboutId,
                Description = experienceDto.Description,
                Title = experienceDto.Title,
                StartDate = Convert.ToDateTime(experienceDto.StartDate),
                EndDate = Convert.ToDateTime(experienceDto.EndDate),
                OrderNo = experienceDto.OrderNo
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }

    public async Task<IEnumerable<ExperienceDto>> GetExperiencesAsync(Guid aboutId)
    {
        var experiences = await _repository.GetListAsync(t => t.AboutId == aboutId);

        return experiences.Select(s => new ExperienceDto
        {
            Id = s.Id,
            AboutId = s.AboutId,
            Description = s.Description,
            Title = s.Title,
            StartDate = s.StartDate.ToShortDateString(),
            EndDate = s.EndDate?.ToShortDateString(),
            CreationTime = s.CreationTime,
            LastModificationTime = s.LastModificationTime,
            IsDeleted = s.IsDeleted,
            OrderNo = s.OrderNo
        });
    }

    public async Task<ExperienceDto> UpdateExperienceAsync(ExperienceDto request)
    {
        var experience = await _repository.FindAsync(request.Id);

        if (experience is null) return new ExperienceDto();

        experience.Description = request.Description;
        experience.Title = request.Title;
        experience.StartDate = Convert.ToDateTime(request.StartDate);
        experience.EndDate = Convert.ToDateTime(request.EndDate);
        experience.OrderNo = request.OrderNo;

        var result = await _repository.UpdateAsync(experience, true);

        return new ExperienceDto
        {
            Id = result.Id,
            Description = result.Description,
            Title = result.Title,
            StartDate = result.StartDate.ToShortDateString(),
            EndDate = result.EndDate?.ToShortDateString(),
            CreationTime = result.CreationTime,
            LastModificationTime = result.LastModificationTime,
            OrderNo = result.OrderNo
        };
    }

    public Task DeleteExperienceAsync(Guid id) => _repository.DeleteAsync(id, true);
}