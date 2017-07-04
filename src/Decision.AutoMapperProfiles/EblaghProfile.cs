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
using Decision.ViewModel.Eblagh;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class EblaghProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<Eblagh, EblaghViewModel>()
            .ForMember(d => d.Empno, m => m.MapFrom(s => s.Empno))
            .ForMember(d => d.RealUnit, m => m.MapFrom(s => s.Place.RealUnit.NamOrganUnit))
            .ForMember(d => d.CostUnit, m => m.MapFrom(s => s.Place.CostUnit.NamOrganUnit))
            .ForMember(d => d.SematDsc, m => m.MapFrom(s => s.Semat.Dsc))
            .ForMember(d => d.SetadiDsc, m => m.MapFrom(s => s.SetadiCod))
            .IgnoreAllNonExisting();
        }

    }
}
