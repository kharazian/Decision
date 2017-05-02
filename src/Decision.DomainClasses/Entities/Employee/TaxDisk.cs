namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxDisk")]
    public partial class TaxDisk
    {
        [Key]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [StringLength(12)]
        public string TaxNoDossier { get; set; }

        [StringLength(1)]
        public string ElementryPay { get; set; }

        [StringLength(1)]
        public string SecondryPay { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(12)]
        public string EcononicCode { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [StringLength(6)]
        public string Personal1Permit { get; set; }

        [StringLength(30)]
        public string Man1Permit { get; set; }

        [StringLength(6)]
        public string Personal2Permit { get; set; }

        [StringLength(30)]
        public string Man2Permit { get; set; }
    }
}
