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
using Decision.ViewModel.EmpRelative;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class EmpRelativeProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<EmpRelative, EmpRelativeViewModel>()
            .ForMember(d => d.ReltypeDsc, m => m.MapFrom(s => s.Reltype.Dsc))
            .ForMember(d => d.SexDsc, m => m.MapFrom(s => s.Sex.Dsc))
            .ForMember(d => d.HealthDsc, m => m.MapFrom(s => s.Helath.Dsc))
            .ForMember(d => d.MarriDsc, m => m.MapFrom(s => s.Mariage.Dsc))
            .ForMember(d => d.DegreeDsc, m => m.MapFrom(s => s.Degree.Dsc))
            .ForMember(d => d.MajorDsc, m => m.MapFrom(s => s.Major.DscMajor))
            .IgnoreAllNonExisting();
        }

    }
}
