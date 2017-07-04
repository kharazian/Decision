namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmPaysRasmy")]
    public partial class HokmPaysRasmy
    {
        public string HokmYear { get; set; }
        public int Seq { get; set; }
        public string PayCod { get; set; }
        public decimal Price { get; set; }
        public virtual ItemsDsc Pay { get; set; }
    }
}
