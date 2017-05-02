namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaSavRel")]
    public partial class LoaSavRel
    {
        [Key]
        [StringLength(4)]
        public string GharsCod { get; set; }

        [Required]
        [StringLength(4)]
        public string LoanTypeCod { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public virtual ItemsDsc ItemsDsc { get; set; }

        public virtual ItemsDsc ItemsDsc1 { get; set; }
    }
}
