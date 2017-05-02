namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinGrpMem")]
    public partial class FinGrpMem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string GrpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string OprCod { get; set; }

        public virtual FinGrp FinGrp { get; set; }
    }
}
