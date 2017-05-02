namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MamorPlace")]
    public partial class MamorPlace
    {
        [Key]
        [StringLength(3)]
        public string Code { get; set; }

        [Required]
        [StringLength(40)]
        public string Dsc { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(3)]
        public string RadKNo { get; set; }

        [StringLength(3)]
        public string RadMNo { get; set; }

        [StringLength(3)]
        public string RadTNo { get; set; }

        [StringLength(3)]
        public string RadJNo { get; set; }

        [StringLength(3)]
        public string TitKNo { get; set; }

        [StringLength(3)]
        public string TitMNo { get; set; }

        [StringLength(3)]
        public string TitTNo { get; set; }

        [StringLength(3)]
        public string TitJNo { get; set; }
    }
}
