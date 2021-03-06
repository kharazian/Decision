namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University")]
    public partial class University
    {
        [Key]
        public int Code { get; set; }

        [StringLength(255)]
        public string Dsc { get; set; }

        public double? Kind { get; set; }
    }
}
