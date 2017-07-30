using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.ViewModel.MontlyResult
{
    public class MontlyResultListViewModel
    {
        public IEnumerable<MontlyResultViewModel> MontlyResults { get; set; }
        public MontlyResultSearchRequest Request { get; set; }
    }
}
