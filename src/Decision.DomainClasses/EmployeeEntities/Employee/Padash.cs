namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Padash")]
    public partial class Padash
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string PadashYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string SixMonth { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Famil { get; set; }

        public long SumHokm { get; set; }

        public short? KarHokm { get; set; }

        public short? Absent { get; set; }

        public long? PadashAmnt { get; set; }

        public int? TaxPadash { get; set; }

        [StringLength(1)]
        public string Janbaz { get; set; }

        [Required]
        [StringLength(2)]
        public string Zone { get; set; }

        [Required]
        [StringLength(4)]
        public string Unit { get; set; }

        public byte? Afzayesh { get; set; }

        public byte? Kahesh { get; set; }

        public int? TaxLow { get; set; }

        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(1)]
        public string UnitCod { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Zone Zone1 { get; set; }
    }
}
