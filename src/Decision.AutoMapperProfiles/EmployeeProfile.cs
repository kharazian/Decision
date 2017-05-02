using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using AutoMapper;
using Decision.AutoMapperProfiles.Extentions;
using Decision.DomainClasses.Entities.Employee;
using Decision.Utility;
using Decision.ViewModel.Home;
using Decision.ViewModel.Employee;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class EmployeeProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<Employee, EmployeeDetailsViewModel>()
                .ForMember(d => d.Photo, m => m.MapFrom(s => (s.EmpImage!=null)? s.EmpImage.Photo : BitConverter.GetBytes(0)))
                .ForMember(d => d.BirthCity, m => m.MapFrom(s => s.BirthCity.DscPlace))
                .ForMember(d => d.IssueCity, m => m.MapFrom(s => s.IssueCity.DscPlace))
                .ForMember(d => d.Religion, m => m.MapFrom(s => s.Religion.Dsc))
              .IgnoreAllNonExisting();




        }

    }
}
