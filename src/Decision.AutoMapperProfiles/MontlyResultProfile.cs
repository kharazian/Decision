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
using Decision.ViewModel.MontlyResult;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class MontlyResultProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<MontlyResult, MontlyResultViewModel>()
            .ForMember(d => d.Empno, m => m.MapFrom(s => s.Empno))
            .IgnoreAllNonExisting();
        }

    }
}
