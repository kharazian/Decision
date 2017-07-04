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
using Decision.ViewModel.OtherBime;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class ExperienceProfile : Profile
    {
        protected override void Configure()
        {


            CreateMap<OtherBime, OtherBimeViewModel>()
            .ForMember(d => d.RelTypeDsc, m => m.MapFrom(s => s.RelType.Dsc))
            .ForMember(d => d.BimeDsc, m => m.MapFrom(s => s.Bime.Dsc))
            .IgnoreAllNonExisting();
        }

    }
}
