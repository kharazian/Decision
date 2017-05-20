namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostEnshaee")]
    public partial class PostEnshaee
    {
        [Required]
        [StringLength(5)]
        public string EmpType { get; set; }

        [Key]
        [StringLength(8)]
        public string PostNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Dsc { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }
    }
}
