using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;


namespace Decision.ViewModel.HokmPay
{
    public class HokmPayViewModel
    {
        public string HokmYear { get; set; }
        public int Seq { get; set; }
        public string PayDsc { get; set; }
        public decimal Price { get; set; }

    }
}
