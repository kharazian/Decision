using System;
using Decision.ViewModel.Common;

namespace Decision.ViewModel.OtherBime
{
    public class OtherBimeSearchRequest : BaseSearchRequest
    {
        public String Empno { get; set; }
        public String BimeDsc { get; set; }
    }
}
