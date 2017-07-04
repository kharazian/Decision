using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision.ViewModel.Experience
{
    public class ExperienceListViewModel
    {
        public IEnumerable<ExperienceViewModel> Experiences { get; set; }
        public ExperienceSearchRequest Request { get; set; }
    }
}
