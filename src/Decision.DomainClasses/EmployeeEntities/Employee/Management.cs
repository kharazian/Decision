namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Management")]
    public partial class Management
    {


        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string Manage1No { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string Manage2No { get; set; }

        [Required]
        [StringLength(40)]
        public string NamManagement { get; set; }

        [StringLength(6)]
        public string EmpNo { get; set; }

        [StringLength(11)]
        public string TelNo { get; set; }

        [StringLength(3)]
        public string RadkNo { get; set; }

        [StringLength(3)]
        public string RadMno { get; set; }

        [StringLength(3)]
        public string RadtNo { get; set; }

        [StringLength(3)]
        public string RadjNo { get; set; }

        [StringLength(1)]
        public string UnitCod { get; set; }

        [StringLength(1)]
        public string Enable { get; set; }

        [StringLength(5)]
        public string SematCode { get; set; }

        [StringLength(8)]
        public string PostCode { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

    }
}
