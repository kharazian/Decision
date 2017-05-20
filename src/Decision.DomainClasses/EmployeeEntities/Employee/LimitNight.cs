namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LimitNight")]
    public partial class LimitNight
    {
        [Key]
        [StringLength(2)]
        public string Zone { get; set; }

        [StringLength(250)]
        public string Dsc { get; set; }

        public int? Limit { get; set; }

        public int? Holiday { get; set; }
    }
}
