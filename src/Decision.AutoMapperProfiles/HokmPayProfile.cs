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
using Decision.ViewModel.HokmPay;
using Decision.ViewModel.Employee;
using Decision.ViewModel.Hokm;
using DNT.Extensions;

namespace Decision.AutoMapperProfiles
{
    public class HokmPayProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<HokmPaysRasmy, HokmPayViewModel>()
            .ForMember(d => d.PayDsc, m => m.MapFrom(s => s.Pay.Dsc))
            .IgnoreAllNonExisting();

            CreateMap<HokmPaysKargary, HokmPayViewModel>()
            .ForMember(d => d.PayDsc, m => m.MapFrom(s => s.Pay.Dsc))
            .IgnoreAllNonExisting();

        }

    }
}
