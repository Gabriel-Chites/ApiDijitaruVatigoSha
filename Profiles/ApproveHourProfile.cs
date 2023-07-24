using AutoMapper;
using TreinandoCodinDojo.Dto_s.ApproveHourDto;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Profiles;

public class ApproveHourProfile : Profile
{
    public ApproveHourProfile()
    {
        CreateMap<CreateApproveHourDto, ApproveHours>();
        CreateMap<ApproveHours, ReadApproveHourDto>();
    }
}
