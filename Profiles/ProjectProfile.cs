using AutoMapper;

using TreinandoCodinDojo.Dto_s.ProjectDto;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Profiles;

public class ProjectProfile : Profile
{
    public ProjectProfile()
    {
        CreateMap<CreateProjectDto, Project>();
        CreateMap<Project, ReadProjectDto>();
        CreateMap<UpdateProjectDto, Project>();
    }
}
