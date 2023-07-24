using AutoMapper;
using TreinandoCodinDojo.Dto_s.CollaboratorDto;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Profiles;

public class CollaboratorProfile : Profile
{
    public CollaboratorProfile()
    {
        CreateMap<CreateCollaboratorDto, Collaborator>();
        CreateMap<Collaborator, ReadCollaboratorDto>();  
    }
}
