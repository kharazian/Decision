namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sal")]
    public partial class Sal
    {
        public int SalID { get; set; }

        public byte? IsDefault { get; set; }
    }
}
