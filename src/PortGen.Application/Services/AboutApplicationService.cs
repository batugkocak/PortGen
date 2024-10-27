using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PortGen.Abstract;
using PortGen.DTOs;
using PortGen.Entities;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectExtending;

namespace PortGen.Services;

public class AboutApplicationService : ApplicationService, IAboutApplicationService
{
    private readonly IRepository<About, Guid> _aboutRepository;
    private readonly IMapper _mapper;

    public AboutApplicationService(IRepository<About, Guid> aboutRepository, IMapper mapper)
    {
        _aboutRepository = aboutRepository;
        _mapper = mapper;
    }

    public void CreateAbout(AboutDto aboutDto)
    {
        _aboutRepository.InsertAsync(new About
        {
            Name = aboutDto.Name,
            Surname = aboutDto.Surname,
            Information = aboutDto.Information,
        });
    }

    public async Task<AboutDto> GetAboutByIdAsync(Guid id)
    {
        var getAbout = await _aboutRepository.GetAsync(t => t.Id == id && !t.IsDeleted);

        return new AboutDto
        {
            Id = getAbout.Id,
            Information = getAbout.Information,
            Name = getAbout.Name,
            Surname = getAbout.Surname,
            CreationTime = getAbout.CreationTime
        };
    }

    public async Task<IEnumerable<AboutDto>> GetAboutAsync()
    {
        var aboutList = await _aboutRepository.GetListAsync();

        return aboutList.Select(a => new AboutDto
        {
            Id = a.Id,
            Name = a.Name,
            Surname = a.Surname,
            Information = a.Information,
            CreationTime = a.CreationTime,
            LastModificationTime = a.LastModificationTime,
            IsDeleted = a.IsDeleted
        });
    }

    public async Task<AboutDto> UpdateAboutAsync(AboutDto aboutDto)
    {
        var about = await _aboutRepository.FindAsync(aboutDto.Id);
        if (about is null) return new AboutDto();

        about.Name = aboutDto.Name;
        about.Surname = aboutDto.Surname;
        about.Information = aboutDto.Information;
        about.LastModificationTime = DateTime.Now;

        var result = await _aboutRepository.UpdateAsync(about, true);

        return new AboutDto
        {
            Id = result.Id,
            Name = result.Name,
            Surname = result.Surname,
            Information = result.Information,
            CreationTime = result.CreationTime,
            LastModificationTime = result.LastModificationTime,
            IsDeleted = result.IsDeleted
        };
    }

    public Task DeleteAboutAsync(Guid id)
    {
        return _aboutRepository.DeleteAsync(id, true);
    }
}