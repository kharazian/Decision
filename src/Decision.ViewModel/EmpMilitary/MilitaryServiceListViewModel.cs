using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.ViewModel.EmpMilitary
{
    public class MilitaryServiceListViewModel
    {
        public IEnumerable<MilitaryServiceViewModel> Militaries{ get; set; }
        public MilitaryServiceSearchRequest Request { get; set; }
    }
}
