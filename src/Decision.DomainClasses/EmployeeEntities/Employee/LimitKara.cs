namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LimitKara")]
    public partial class LimitKara
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Empno { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ZoneCode { get; set; }

        [StringLength(4)]
        public string Years { get; set; }

        [StringLength(2)]
        public string Mont { get; set; }

        [StringLength(4)]
        public string LHokmYear { get; set; }

        [StringLength(8)]
        public string LRunDate { get; set; }

        [StringLength(51)]
        public string Family { get; set; }

        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(4)]
        public string Unit { get; set; }

        [StringLength(40)]
        public string NamOrganUnit { get; set; }

        [StringLength(40)]
        public string NamManagement { get; set; }

        [StringLength(40)]
        public string Moaven { get; set; }

        [StringLength(2)]
        public string Manage1No { get; set; }

        [StringLength(2)]
        public string Manage2No { get; set; }

        [Column(TypeName = "money")]
        public decimal? Mabna { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sanavat { get; set; }

        [Column(TypeName = "money")]
        public decimal? Shoghl { get; set; }

        [StringLength(1)]
        public string GetempType { get; set; }

        [StringLength(50)]
        public string emptypdsc { get; set; }

        public int? Lseq { get; set; }

        [StringLength(1)]
        public string backup { get; set; }

        [StringLength(1)]
        public string SetadiCod { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tatbigh { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public int? EzafehKar { get; set; }

        public int? HoliDay { get; set; }

        public int? NightPay { get; set; }

        public int? BadazZohr { get; set; }

        public int? SahmPlus { get; set; }

        [Column(TypeName = "money")]
        public decimal? KaraPer { get; set; }
    }
}
