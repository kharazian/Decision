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
    public class EmployeeProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Employee, EmployeeDetailsViewModel>()
            .ForMember(d => d.Photo, m => m.MapFrom(s => s.EmpImage.Photo))
            .ForMember(d => d.BirthCity, m => m.MapFrom(s => s.BirthCity.DscPlace))
            .ForMember(d => d.IssueCity, m => m.MapFrom(s => s.IssueCity.DscPlace))
            .ForMember(d => d.ReligionDsc, m => m.MapFrom(s => s.Religion.Dsc))
            .ForMember(d => d.EmpType, m => m.MapFrom(s => s.EmpTypeDsc.Dsc))
            .ForMember(d => d.Unit, m => m.MapFrom(s => s.UnitPlace.Manage2.NamManagement + " / " + s.UnitPlace.NamOrganUnit))
            .ForMember(d => d.RealPlace, m => m.MapFrom(s => s.RUnitPlace.Manage2.NamManagement + " / " + s.RUnitPlace.NamOrganUnit))
            .ForMember(d => d.MarriageDsc, m => m.MapFrom(s => s.Marriage.Dsc))
            .ForMember(d => d.NationalDsc, m => m.MapFrom(s => s.National.Dsc))
            .ForMember(d => d.NezStatDsc, m => m.MapFrom(s => s.NezStat.Dsc))
            .ForMember(d => d.LDegreeDsc, m => m.MapFrom(s => s.LDegree.Dsc))
            .ForMember(d => d.LMajorDsc, m => m.MapFrom(s => s.LMajor.DscMajor))
            .ForMember(d => d.Acc, m => m.MapFrom(s => s.AccNoSh))
            .ForMember(d => d.InsTypeDsc, m => m.MapFrom(s => s.InsT.Dsc))
            .ForMember(d => d.BloodDsc, m => m.MapFrom(s => s.Blood.Dsc))
            .ForMember(d => d.HealthDsc, m => m.MapFrom(s => s.Health.Dsc))
            .ForMember(d => d.HouseDsc, m => m.MapFrom(s => s.House.Dsc))
            .ForMember(d => d.LPostEblagh, m => m.MapFrom(s => s.LPost.POstDsc))
            .IgnoreAllNonExisting();

            CreateMap<Employee, EmployeeViewModel>()
            .ForMember(d => d.Photo, m => m.MapFrom(s => s.EmpImage.Photo))
            .ForMember(d => d.BirthCity, m => m.MapFrom(s => s.BirthCity.DscPlace))
            .ForMember(d => d.IssueCity, m => m.MapFrom(s => s.IssueCity.DscPlace))
            .ForMember(d => d.ReligionDsc, m => m.MapFrom(s => s.Religion.Dsc))
            //.ForMember(d => d.StopStat, m => m.MapFrom(s => s.StopStat))
            .ForMember(d => d.EmpType, m => m.MapFrom(s => s.EmpTypeDsc.Dsc))
            .ForMember(d => d.Unit, m => m.MapFrom(s => s.UnitPlace.Manage2.NamManagement + " / " + s.UnitPlace.NamOrganUnit))
            .ForMember(d => d.RealPlace, m => m.MapFrom(s => s.RUnitPlace.Manage2.NamManagement + " / " + s.RUnitPlace.NamOrganUnit))
            .ForMember(d => d.MarriageDsc, m => m.MapFrom(s => s.Marriage.Dsc))
            .ForMember(d => d.NationalDsc, m => m.MapFrom(s => s.National.Dsc))
            .ForMember(d => d.NezStatDsc, m => m.MapFrom(s => s.NezStat.Dsc))
            .ForMember(d => d.LDegreeDsc, m => m.MapFrom(s => s.LDegree.Dsc))
            .ForMember(d => d.LMajorDsc, m => m.MapFrom(s => s.LMajor.DscMajor))
            .ForMember(d => d.Acc, m => m.MapFrom(s => s.AccNoSh))
            .ForMember(d => d.InsTypeDsc, m => m.MapFrom(s => s.InsT.Dsc))
            .ForMember(d => d.BloodDsc, m => m.MapFrom(s => s.Blood.Dsc))
            .ForMember(d => d.HealthDsc, m => m.MapFrom(s => s.Health.Dsc))
            .ForMember(d => d.HouseDsc, m => m.MapFrom(s => s.House.Dsc))
            .ForMember(d => d.LPostEblagh, m => m.MapFrom(s => s.LPost.POstDsc))
            .IgnoreAllNonExisting();


            CreateMap<EmpRelative, EmpRelativeViewModel>();
            //.IgnoreAllNonExisting();
        }

    }
}
