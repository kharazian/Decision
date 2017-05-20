namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Messages
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(35)]
        public string FormName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Code { get; set; }

        [Required]
        [StringLength(300)]
        public string Dscr { get; set; }

        public byte Type { get; set; }
    }
}
