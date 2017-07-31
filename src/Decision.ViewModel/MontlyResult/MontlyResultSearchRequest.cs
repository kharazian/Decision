using System;
using Decision.ViewModel.Common;

namespace Decision.ViewModel.MontlyResult
{
    public class MontlyResultSearchRequest : BaseSearchRequest
    {
        public String Empno { get; set; }
        public String ResultYear { get; set; }
        public String ResultMonth { get; set; }
    }
}
