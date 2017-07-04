using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.ViewModel.EmpDegree
{
    public class EmpDegreeListViewModel
    {
        public IEnumerable<EmpDegreeViewModel> Degrees { get; set; }
        public EmpDegreeSearchRequest Request { get; set; }
    }
}
