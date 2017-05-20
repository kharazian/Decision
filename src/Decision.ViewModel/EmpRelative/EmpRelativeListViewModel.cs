using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.ViewModel.EmpRelative
{
    public class EmpRelativeListViewModel
    {
        public IEnumerable<EmpRelativeViewModel> Relatives { get; set; }
        public EmpRelativeSearchRequest Request { get; set; }
    }
}
