using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;


namespace Decision.ViewModel.Eblagh
{
    public class EblaghViewModel
    {
        public string HokmYear { get; set; }
        public int Seq { get; set; }
        public string Empno { get; set; }
        public string SequenceNo { get; set; }
        public string RunDate { get; set; }
        public string Permanent { get; set; }
        public string RealUnit { get; set; }
        public string CostUnit { get; set; }
        public string Post { get; set; }
        public string SematDsc { get; set; }
        public string SetadiDsc { get; set; }
        public bool? CostCenter { get; set; }
        public string EblType { get; set; }
        public string EblDes { get; set; }
    }
}
