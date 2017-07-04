namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherBime")]
    public partial class OtherBime : ITenant
    {
        [StringLength(6)]
        [Column("EmpNo")]
        public string Empno { get; set; }

        [StringLength(5)]
        public string RelTypeCod { get; set; }

        [StringLength(2)]
        public string RelSequence { get; set; }

        [StringLength(5)]
        public string BimeCod { get; set; }

        [StringLength(4)]
        public string StartYear { get; set; }

        [StringLength(2)]
        public string StartMonth { get; set; }

        [StringLength(4)]
        public string EndYear { get; set; }

        [StringLength(2)]
        public string EndMonth { get; set; }

        [StringLength(12)]
        public string InsNo { get; set; }

        [Required]
        [StringLength(1)]
        public string Calck { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual CodeFile RelType { get; set; }

        public virtual CodeFile Bime { get; set; }

        public EmpRelative empRelation { get; set; }

    }
}
