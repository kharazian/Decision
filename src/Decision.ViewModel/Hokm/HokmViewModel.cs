using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.ViewModel.HokmPay;
using Decision.DomainClasses.EmployeeEntities;


namespace Decision.ViewModel.Hokm
{
    public class HokmViewModel
    {
        public string HokmYear { get; set; }
        public int Seq { get; set; }
        public string Empno { get; set; }
        public string SequenceNo { get; set; }
        public string RunDate { get; set; }
        public string HokmTypeDsc { get; set; }
        public string RastehDsc { get; set; }
        public string ReshtehDsc { get; set; }
        public string DegreeDsc { get; set; }
        public string MajorDsc { get; set; }
        public string Grooh { get; set; }
        public int Sanavat { get; set; }
        public string Permanent { get; set; }
        public string MarriedDsc { get; set; }
        public string FamilyProtector { get; set; }
        public int? NoChild { get; set; }
        public string FDsc { get; set; }
        public string StopStat { get; set; }
        public ICollection<HokmPayViewModel> HokmPays { get; set; }
    }
}
