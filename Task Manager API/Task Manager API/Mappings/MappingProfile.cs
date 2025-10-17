using AutoMapper;
using Task_Manager_API.DTOs;
using Task_Manager_API.Models;

namespace Task_Manager_API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskItem, TaskDto>().ReverseMap();
            CreateMap<RegisterDto, ApplicationUser>();
        }
    }
}
