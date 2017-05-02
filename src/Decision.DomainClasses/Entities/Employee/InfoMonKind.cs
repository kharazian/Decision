namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoMonKind")]
    public partial class InfoMonKind
    {
        public int ID { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(1)]
        public string Active { get; set; }

        public int? RolId { get; set; }
    }
}
