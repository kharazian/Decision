namespace Decision.DomainClasses.Entities.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRFBackMaster")]
    public partial class PRFBackMaster
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string empno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ResultYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ResultMonth { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string RunDate { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Family { get; set; }

        [StringLength(15)]
        public string AccNo { get; set; }

        [StringLength(2)]
        public string BankNo { get; set; }

        [StringLength(40)]
        public string BankNam { get; set; }

        [StringLength(4)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string NamOrganUnit { get; set; }

        [StringLength(1)]
        public string ItemTyp { get; set; }

        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(30)]
        public string EmpTypDesc { get; set; }

        public short? CurrMonthActivity { get; set; }

        [StringLength(2)]
        public string ZoneCode { get; set; }

        [StringLength(30)]
        public string ZoneDesc { get; set; }

        public long? SumPay { get; set; }

        public long? SumDeduct { get; set; }

        public long? NetPay { get; set; }
    }
}
