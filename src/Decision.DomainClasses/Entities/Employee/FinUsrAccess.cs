namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinUsrAccess")]
    public partial class FinUsrAccess
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string oprCod { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ClassNo { get; set; }

        public byte UseOk { get; set; }

        public byte? Tag { get; set; }

        public virtual FinClass FinClass { get; set; }

        public virtual Finuser Finuser { get; set; }
    }
}
