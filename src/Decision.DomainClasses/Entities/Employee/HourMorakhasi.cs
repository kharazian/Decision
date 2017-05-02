namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HourMorakhasi")]
    public partial class HourMorakhasi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string StartDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string StartTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string Empno { get; set; }

        [StringLength(4)]
        public string EndTime { get; set; }

        [StringLength(30)]
        public string Dsc { get; set; }

        [StringLength(6)]
        public string DirectorEmpNo { get; set; }

        [StringLength(1)]
        public string Permanet { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }
    }
}
