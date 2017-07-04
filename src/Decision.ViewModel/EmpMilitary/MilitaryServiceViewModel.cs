using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;


namespace Decision.ViewModel.EmpMilitary
{
    public class MilitaryServiceViewModel
    {
        public string Empno { get; set; }
        public string TypeDsc { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string PlcDsc { get; set; }
        public int? JanBazPercent { get; set; }
        public string RunDate { get; set; }
        public string LetNo { get; set; }
        public string Dsc { get; set; }
        public string Groups { get; set; }
    }
}
