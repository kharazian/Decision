namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpRelative")]
    public partial class EmpRelative : ITenant
    {
        [StringLength(6)]
        [Column("Empno")]
        public string Empno { get; set; }
        public string ReltypeCod { get; set; }
        [StringLength(2)]
        public string RelSequence { get; set; }

        [Required]
        [StringLength(14)]
        public string IdNo { get; set; }

        [StringLength(1)]
        public string TakafolStat { get; set; }

        [Required]
        [StringLength(20)]
        public string RelNam { get; set; }

        [StringLength(30)]
        public string Family { get; set; }

        [StringLength(5)]
        public string SexCod { get; set; }

        [Required]
        [StringLength(8)]
        public string BirthDate { get; set; }

        [Required]
        [StringLength(10)]
        public string MelliCode { get; set; }

        [Required]
        [StringLength(20)]
        public string FatherNam { get; set; }

        [StringLength(5)]
        public string HealthCod { get; set; }

        [StringLength(30)]
        public string jobDsc { get; set; }

        [StringLength(5)]
        public string RelDeg { get; set; }

        [StringLength(5)]
        public string DegreeCod { get; set; }

        [StringLength(4)]
        public string MajorCod { get; set; }

        public float? Gpa { get; set; }

        [StringLength(5)]
        public string MarriCod { get; set; }

        [StringLength(5)]
        public string WarRelCod { get; set; }

        [StringLength(8)]
        public string StartDate { get; set; }

        [StringLength(8)]
        public string ChildDatMarrid { get; set; }

        [StringLength(5)]
        public string Sections { get; set; }

        [StringLength(8)]
        public string ChildDatDie { get; set; }

        [StringLength(1)]
        public string RefahiState { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        public CodeFile Reltype { get; set; }
        public CodeFile Sex { get; set; }
        public CodeFile Helath { get; set; }
        public CodeFile Mariage { get; set; }
        public CodeFile Degree { get; set; }
        public Major Major { get; set; }

        public ICollection<OtherBime> Bimes { get; set; }
    }
}
