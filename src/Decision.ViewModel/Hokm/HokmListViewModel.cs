using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.ViewModel.Hokm
{
    public class HokmListViewModel
    {
        public IEnumerable<HokmViewModel> Hokms { get; set; }
        public HokmSearchRequest Request { get; set; }
    }
}
