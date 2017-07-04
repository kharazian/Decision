using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.ViewModel.OtherBime
{
    public class OtherBimeListViewModel
    {
        public IEnumerable<OtherBimeViewModel> OtherBimes { get; set; }
        public OtherBimeSearchRequest Request { get; set; }
    }
}
