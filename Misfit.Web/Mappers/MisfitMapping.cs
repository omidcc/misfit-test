using System;
using AutoMapper;
using Misfit.Model;
using Misfit.Web.ViewModels;

namespace Misfit.Web.Mappers
{
    public class MisfitMapping : Profile
    {
        public MisfitMapping()
        {
            CreateMap<UserViewModel, User>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => s.UserName))
                .ReverseMap();

            CreateMap<ResultViewModel, UserResult>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstNumber, opt => opt.MapFrom(s => s.FirstNumber))
                .ForMember(d => d.SecondNumber, opt => opt.MapFrom(s => s.SecondNumber))
                .ForMember(d => d.Sum, opt => opt.MapFrom(s => s.Sum))
                .ForMember(d => d.User, opt => opt.MapFrom(s => s.User))
                .ReverseMap();
        }
    }
}
