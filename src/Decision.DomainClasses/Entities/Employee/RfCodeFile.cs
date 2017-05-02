namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RfCodeFile")]
    public partial class RfCodeFile
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MainCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string SubCode1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string SubCode2 { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(9)]
        public string Code { get; set; }

        [StringLength(9)]
        public string ParentCode { get; set; }

        [StringLength(10)]
        public string RfDate { get; set; }

        public long SahmEmp { get; set; }

        public long SahmBoss { get; set; }

        public long? TotalValwe { get; set; }

        public float? BossPercent { get; set; }

        public float? EmpPercent { get; set; }
    }
}
