using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;


namespace Decision.ViewModel.EmpDegree
{
    public class EmpDegreeViewModel
    {
        public string Empno { get; set; }
        public string DegreeDsc { get; set; }
        public string DegreeDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string MajorDsc { get; set; }
        public string MinorDsc { get; set; }
        public string CountryDsc { get; set; }
        public string SchoolOldNam { get; set; }
        public float Gpa1 { get; set; }
        public string SchoolName { get; set; }
        public bool? GetDegree { get; set; }
        public string Gpa2 { get; set; }        

    }
}
