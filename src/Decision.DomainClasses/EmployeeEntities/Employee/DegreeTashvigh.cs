namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DegreeTashvigh")]
    public partial class DegreeTashvigh
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string DegreeDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MadrakCod { get; set; }

        [Column(TypeName = "money")]
        public decimal DegreePrice { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }
    }
}
