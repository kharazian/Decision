namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpWriting")]
    public partial class EmpWriting
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string WriteDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(70)]
        public string Dsc { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
