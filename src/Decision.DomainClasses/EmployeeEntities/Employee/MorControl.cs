namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MorControl")]
    public partial class MorControl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string EmpNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Unit { get; set; }

        [Required]
        [StringLength(2)]
        public string ManageNo1 { get; set; }

        [Required]
        [StringLength(2)]
        public string ManageNo2 { get; set; }

        [StringLength(4)]
        public string StartYear { get; set; }

        [StringLength(2)]
        public string StartMont { get; set; }

        [StringLength(4)]
        public string EndYear { get; set; }

        [StringLength(2)]
        public string EndMont { get; set; }
    }
}
