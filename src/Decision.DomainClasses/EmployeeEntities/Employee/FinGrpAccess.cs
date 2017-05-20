namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinGrpAccess")]
    public partial class FinGrpAccess
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string GrpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ClassNo { get; set; }

        public byte UseOk { get; set; }

        public virtual FinClass FinClass { get; set; }

        public virtual FinGrp FinGrp { get; set; }
    }
}
