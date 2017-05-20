namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_Log
    {
        [Key]
        public long LogId { get; set; }

        public int LogStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        public DateTime? LogStatusDateTime { get; set; }

        [Required]
        [StringLength(15)]
        public string LogStatusClientIpAddress { get; set; }
    }
}
