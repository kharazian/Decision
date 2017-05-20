namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodeFileTax")]
    public partial class CodeFileTax
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Dsc { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string Tag { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }
    }
}
