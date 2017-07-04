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
using Decision.ViewModel.Experience;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class OtherBimeProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<Experience, ExperienceViewModel>()
            .ForMember(d => d.Empno, m => m.MapFrom(s => s.Empno))
            .IgnoreAllNonExisting();
        }

    }
}
