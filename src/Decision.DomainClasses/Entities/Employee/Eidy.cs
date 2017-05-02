namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Eidy")]
    public partial class Eidy
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string EidyYear { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Family { get; set; }

        public short? Karkerd { get; set; }

        public long? EidyAmount { get; set; }

        [StringLength(2)]
        public string Zone { get; set; }

        [StringLength(4)]
        public string Unit { get; set; }

        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(1)]
        public string UnitCod { get; set; }

        public short? Absent { get; set; }

        public long? EidyTax { get; set; }

        public byte? Afzayesh { get; set; }

        public byte? Kahesh { get; set; }

        public virtual Zone Zone1 { get; set; }
    }
}
