namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HourMamoriat")]
    public partial class HourMamoriat
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string StartDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string StartTime { get; set; }

        [StringLength(40)]
        public string PlaceMam { get; set; }

        [StringLength(40)]
        public string SubjectMam { get; set; }

        [StringLength(4)]
        public string EndTime { get; set; }

        [StringLength(6)]
        public string DirectorEmp { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }
    }
}
