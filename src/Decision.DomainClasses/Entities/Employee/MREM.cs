namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MREM")]
    public partial class MREM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Y { get; set; }

        [Key]
        [Column(Order = 2)]
        public float R { get; set; }

        [StringLength(5)]
        public string EmpTyp { get; set; }

        [StringLength(20)]
        public string empTypDsc { get; set; }

        [StringLength(2)]
        public string ZoneCod { get; set; }

        [StringLength(20)]
        public string EmpNam { get; set; }

        [StringLength(30)]
        public string Family { get; set; }

        [StringLength(70)]
        public string UnitDesc { get; set; }
    }
}
