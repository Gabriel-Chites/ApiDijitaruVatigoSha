using AutoMapper;
using TreinandoCodinDojo.Dto_s.TimeRecordingDto;
using TreinandoCodinDojo.Models;

namespace TreinandoCodinDojo.Profiles;

public class TimeRecordingProfile : Profile
{
    public TimeRecordingProfile()
    {
        CreateMap<CreateTimeRecordingDto, TimeRecording>();
        CreateMap<TimeRecording, ReadTimeRecordingDto>();
    }
}
