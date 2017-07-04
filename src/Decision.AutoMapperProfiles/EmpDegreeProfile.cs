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
using Decision.ViewModel.EmpDegree;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class EmpDegreeProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<EmpDegree, EmpDegreeViewModel>()
            .ForMember(d => d.DegreeDsc, m => m.MapFrom(s => s.Degree.Dsc))
            .ForMember(d => d.MajorDsc, m => m.MapFrom(s => s.Major.DscMajor))
            .ForMember(d => d.CountryDsc, m => m.MapFrom(s => s.Country.Dsc))
            .ForMember(d => d.SchoolName, m => m.MapFrom(s => s.School.Dsc))
            .IgnoreAllNonExisting();
        }

    }
}
