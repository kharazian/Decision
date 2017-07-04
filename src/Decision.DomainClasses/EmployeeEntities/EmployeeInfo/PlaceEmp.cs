namespace Decision.DomainClasses.EmployeeEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaceEmp")]
    public partial class PlaceEmp : ITenant
    {
        public string HokmYear { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seq { get; set; }
        public string Unit { get; set; }
        public string Empno { get; set; }
        public string RunDate { get; set; }
        public string PostNo { get; set; }
        public string EmpType { get; set; }
        public string TypeCod { get; set; }
        public string Permanent { get; set; }
        public string RealPlace { get; set; }
        public virtual CodeFile EmployeeType { get; set; }
        public virtual OrganUnit RealUnit { get; set; }
        public virtual OrganUnit CostUnit { get; set; }


    }
}
