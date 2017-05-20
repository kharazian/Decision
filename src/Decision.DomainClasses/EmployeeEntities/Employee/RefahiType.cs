namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RefahiType")]
    public partial class RefahiType
    {
        [Key]
        [StringLength(5)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Dsc { get; set; }
    }
}
