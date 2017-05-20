namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganUnitParent")]
    public partial class OrganUnitParent
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Unit { get; set; }

        [StringLength(5)]
        public string Parent { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(400)]
        public string NamOrganUnit { get; set; }
    }
}
