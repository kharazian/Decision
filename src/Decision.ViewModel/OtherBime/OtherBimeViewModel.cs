using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;


namespace Decision.ViewModel.OtherBime
{
    public class OtherBimeViewModel
    {
        public string Empno { get; set; }
        public string RelTypeCod { get; set; }
        public string RelTypeDsc { get; set; }
        public string RelSequence { get; set; }
        public string BimeDsc { get; set; }
        public string BimeType { get { return BimeDsc.Contains("فرهنگی") ? "فرهنگی" : (BimeDsc.Contains("آتش نشانی") ? "آتش نشانی" : "شهرداری"); } }
        public string StartYear { get; set; }
        public string StartMonth { get; set; }
        public Boolean IsEnable { get { return EndYear==null?true:(EndYear.Replace(" ","") == "" ? true : false); } }
        public string EndYear { get; set; }
        public string EndMonth { get; set; }
        public string InsNo { get; set; }
        public string Calck { get; set; }
    }
}
