namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessPost")]
    public partial class AccessPost
    {
        [Key]
        public long RowNum { get; set; }

        [StringLength(6)]
        public string EmpNo { get; set; }

        [StringLength(10)]
        public string OprCode { get; set; }

        [StringLength(4)]
        public string Unit { get; set; }

        [StringLength(10)]
        public string ExePostCode { get; set; }

        [StringLength(5)]
        public string SematCode { get; set; }

        public bool? Active { get; set; }

        [StringLength(5)]
        public string TypAccess { get; set; }

        [StringLength(15)]
        public string OprCod2 { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }
    }
}
