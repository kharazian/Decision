namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganPost")]
    public partial class OrganPost
    {
        [Key]
        [StringLength(5)]
        public string CodePost { get; set; }

        [Required]
        [StringLength(6)]
        public string IdOrgan { get; set; }

        [StringLength(6)]
        public string EmpNo { get; set; }

        [StringLength(10)]
        public string PostCodeId { get; set; }

        [StringLength(15)]
        public string OprCode { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        public virtual LevelChart LevelChart { get; set; }

        public virtual PostHokm PostHokm { get; set; }
    }
}
