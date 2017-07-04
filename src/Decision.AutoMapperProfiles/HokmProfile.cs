using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using AutoMapper;
using Decision.AutoMapperProfiles.Extentions;
using Decision.DomainClasses.EmployeeEntities;
using Decision.Utility;
using Decision.ViewModel.Home;
using Decision.ViewModel.Employee;
using Decision.ViewModel.Hokm;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class HokmProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<HokmRasmy, HokmViewModel>()
            .ForMember(d => d.HokmTypeDsc, m => m.MapFrom(s => s.HokmT.Dsc))
            .ForMember(d => d.RastehDsc, m => m.MapFrom(s => s.Rasteh.Dsc))
            .ForMember(d => d.ReshtehDsc, m => m.MapFrom(s => s.Reshteh.Dsc))
            .ForMember(d => d.DegreeDsc, m => m.MapFrom(s => s.Degree.Dsc))
            .ForMember(d => d.MajorDsc, m => m.MapFrom(s => s.Major.DscMajor))
            .ForMember(d => d.MarriedDsc, m => m.MapFrom(s => s.Married.Dsc))
            .IgnoreAllNonExisting();

            CreateMap<HokmKargary, HokmViewModel>()
            .ForMember(d => d.HokmTypeDsc, m => m.MapFrom(s => s.HokmT.Dsc))
            .ForMember(d => d.DegreeDsc, m => m.MapFrom(s => s.Degree.Dsc))
            .ForMember(d => d.MajorDsc, m => m.MapFrom(s => s.Major.DscMajor))
            .ForMember(d => d.MarriedDsc, m => m.MapFrom(s => s.Married.Dsc))
            .IgnoreAllNonExisting();

            CreateMap<GharardadSaaty, HokmViewModel>()
            .ForMember(d => d.HokmTypeDsc, m => m.MapFrom(s => s.HokmT.Dsc))
            .ForMember(d => d.DegreeDsc, m => m.MapFrom(s => s.Degree.Dsc))
            .ForMember(d => d.MajorDsc, m => m.MapFrom(s => s.Major.DscMajor))
            .IgnoreAllNonExisting();
        }

    }
}
