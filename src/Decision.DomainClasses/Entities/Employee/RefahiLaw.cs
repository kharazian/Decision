namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RefahiLaw")]
    public partial class RefahiLaw
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MainCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string SubCode1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string SubCode2 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(8)]
        public string LawDate { get; set; }

        public long? SahmEmp { get; set; }

        public long? SahmBoss { get; set; }

        public long? TotalValwe { get; set; }

        public float? BossPercent { get; set; }

        public float? EmpPercent { get; set; }
    }
}
