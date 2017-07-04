namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Eblagh")]
    public partial class Eblagh : ITenant
    {
        public string HokmYear { get; set; }
        public int Seq { get; set; }
        [Column("EmpNo")]
        public string Empno { get; set; }
        public string SequenceNo { get; set; }
        public string RunDate { get; set; }
        public string Permanent { get; set; }
        public DateTime? CreDat { get; set; }
        public DateTime? UpdDat { get; set; }
        public string OprCod { get; set; }
        public string RealPlace { get; set; }
        public string SematCod { get; set; }
        public string SetadiCod { get; set; }
        public bool? CostCenter { get; set; }
        public string EblType { get; set; }
        public string EblDes { get; set; }
        public virtual PlaceEmp Place { get; set; }
        public virtual CodeFile Semat { get; set; }

    }
}
