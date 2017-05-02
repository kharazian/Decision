namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HokmLaw")]
    public partial class HokmLaw
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string LawDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string HokmType { get; set; }

        public int LengthLHokm { get; set; }

        [Required]
        [StringLength(600)]
        public string FDsc { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile CodeFile { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }
    }
}
