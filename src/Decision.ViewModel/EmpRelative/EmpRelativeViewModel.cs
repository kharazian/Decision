using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;
using Decision.ViewModel.OtherBime;


namespace Decision.ViewModel.EmpRelative
{
    public class EmpRelativeViewModel
    {
        public string Empno { get; set; }
        public string ReltypeDsc { get; set; }
        public string RelSequence { get; set; }
        public string IdNo { get; set; }
        public string TakafolStat { get; set; }
        public Takafol TakafolStatE
        {
            get
            {
                try
                {
                    return (Takafol)Enum.Parse(typeof(Takafol), TakafolStat);
                }
                catch (Exception)
                {
                    return Takafol.None;
                }
            }

        }
        public string RelNam { get; set; }
        public string Family { get; set; }
        public string SexDsc { get; set; }
        public string BirthDate { get; set; }
        public string MelliCode { get; set; }
        public string FatherNam { get; set; }
        public string HealthDsc { get; set; }
        public string jobDsc { get; set; }
        public string RelDeg { get; set; }
        public string DegreeDsc { get; set; }
        public string MajorDsc { get; set; }
        public float? Gpa { get; set; }
        public string MarriDsc { get; set; }
        public string WarRelCod { get; set; }
        public string StartDate { get; set; }
        public string ChildDatMarrid { get; set; }
        public string Sections { get; set; }
        public string ChildDatDie { get; set; }
        public string RefahiState { get; set; }
        public Takafol RefahiStateE
        {
            get
            {
                try
                {
                    return (Takafol)Enum.Parse(typeof(Takafol), RefahiState);
                }
                catch (Exception)
                {
                    return Takafol.None;
                }
            }

        }

        public ICollection<OtherBimeViewModel> Bimes { get; set; }

    }
}
