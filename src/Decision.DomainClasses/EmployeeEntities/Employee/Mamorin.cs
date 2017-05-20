namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mamorin")]
    public partial class Mamorin
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Startdate { get; set; }

        [StringLength(8)]
        public string Enddate { get; set; }

        [Required]
        [StringLength(5)]
        public string MamorCod { get; set; }

        [Required]
        [StringLength(3)]
        public string PlaceCod { get; set; }

        [StringLength(70)]
        public string Dsc { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }
    }
}
