namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KaraSaving")]
    public partial class KaraSaving
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string Years { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string Mont { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string Manage1No { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string Manage2No { get; set; }

        [Required]
        [StringLength(100)]
        public string FileName { get; set; }

        [StringLength(2)]
        public string ZoneCode { get; set; }

        public int? KaraSave { get; set; }
    }
}
