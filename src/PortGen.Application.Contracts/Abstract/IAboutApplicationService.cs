using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortGen.DTOs;
using Volo.Abp.Application.Services;

namespace PortGen.Abstract;

public interface IAboutApplicationService : IApplicationService
{
    public void CreateAbout(AboutDto skillDto);
    public Task<AboutDto> GetAboutByIdAsync(Guid id);
    public Task<IEnumerable<AboutDto>> GetAboutAsync();
    public Task<AboutDto> UpdateAboutAsync(AboutDto aboutDto);
    public Task DeleteAboutAsync(Guid id);
}