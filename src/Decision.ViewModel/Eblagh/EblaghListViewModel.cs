using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.ViewModel.Eblagh
{
    public class EblaghListViewModel
    {
        public IEnumerable<EblaghViewModel> Eblaghs { get; set; }
        public EblaghSearchRequest Request { get; set; }
    }
}
