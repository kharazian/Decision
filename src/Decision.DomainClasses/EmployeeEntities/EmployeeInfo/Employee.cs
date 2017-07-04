
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

namespace Decision.DomainClasses.EmployeeEntities
{
    [Table("Employee")]
    public partial class Employee : ITenant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Photo = BitConverter.GetBytes(0);
        }

        [StringLength(6)]
        [Column("Empno")]
        public string Empno { get; set; }

        [StringLength(20)]
        public string Name { get; set; }


        [StringLength(30)]
        public string Family { get; set; }


        [StringLength(20)]
        public string FatherName { get; set; }

        [StringLength(30)]
        public string LastFamily { get; set; }


        [StringLength(14)]
        public string IdNo { get; set; }

        [StringLength(20)]
        public string IdNoContinued { get; set; }


        [StringLength(8)]
        public string BirthDate { get; set; }


        [StringLength(5)]
        public string SexCod { get; set; }

        [StringLength(10)]
        public string MostakhdemNo { get; set; }


        [StringLength(6)]
        public string BirthCityCod { get; set; }


        [StringLength(6)]
        public string IssueCityCod { get; set; }


        [StringLength(5)]
        public string EmpType { get; set; }

        [StringLength(4)]
        public string Unit { get; set; }

        [StringLength(8)]
        public string GovEmpDate { get; set; }

        [StringLength(8)]
        public string ManEmpDate { get; set; }

        [StringLength(6)]
        public string SanavatHokm { get; set; }

        [StringLength(6)]
        public string SanavatHoghogh { get; set; }

        [StringLength(5)]
        public string SematCod { get; set; }

        [StringLength(10)]
        public string MelliCode { get; set; }


        [StringLength(5)]
        public string MarriCod { get; set; }

        [StringLength(8)]
        public string MarriDate { get; set; }

        public int? NoChild { get; set; }

        [StringLength(5)]
        public string ReligionCod { get; set; }

        [StringLength(5)]
        public string NationalCod { get; set; }

        [StringLength(11)]
        public string TelNo { get; set; }

        [StringLength(11)]
        public string Mobile { get; set; }

        [StringLength(11)]
        public string MainTelNo { get; set; }

        [StringLength(10)]
        public string ZipNo { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(5)]
        public string NezStatCod { get; set; }

        [StringLength(90)]
        public string Addr { get; set; }

        [StringLength(5)]
        public string LDegreeCod { get; set; }

        [StringLength(4)]
        public string LMajorCod { get; set; }

        public int Sanavat { get; set; }


        [StringLength(1)]
        public string StopStat { get; set; }


        [StringLength(1)]
        public string PartTime { get; set; }

        [StringLength(13)]
        public string AccNo { get; set; }

        [StringLength(2)]
        public string BankNo { get; set; }

        [StringLength(4)]
        public string BrnchNo { get; set; }

        [StringLength(2)]
        public string BankSh { get; set; }

        [StringLength(4)]
        public string BranchSh { get; set; }

        [StringLength(5)]
        public string InsType { get; set; }

        [StringLength(12)]
        public string InsNo { get; set; }

        [StringLength(5)]
        public string BloodCod { get; set; }

        [StringLength(5)]
        public string HealthCod { get; set; }

        [StringLength(8)]
        public string BudgetNo { get; set; }

        [StringLength(5)]
        public string HouseCod { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Column(TypeName = "image")]
        public byte[] Signature { get; set; }


        [StringLength(1)]
        public string SetadiCod { get; set; }

        public float RemMorakhasi { get; set; }

        [Column(TypeName = "money")]
        public decimal LastMogharary { get; set; }

        [StringLength(4)]
        public string LHokmYear { get; set; }

        public int? LSeq { get; set; }

        [StringLength(8)]
        public string LPostNoEblagh { get; set; }

        [StringLength(8)]
        public string LPostNoHokm { get; set; }


        [StringLength(8)]
        public string LRunDate { get; set; }

        [StringLength(4)]
        public string HokmType { get; set; }


        [StringLength(1)]
        public string EmpState { get; set; }


        [StringLength(8)]
        public string IssueDate { get; set; }

        [StringLength(2)]
        public string Grooh { get; set; }


        [StringLength(1)]
        public string BackUp { get; set; }


        [StringLength(1)]
        public string Type { get; set; }

        [StringLength(8)]
        public string SanavatDate { get; set; }

        public DateTime? CreDat { get; set; }

        public DateTime? UpdDat { get; set; }

        [StringLength(15)]
        public string OprCod { get; set; }

        [StringLength(2)]
        public string zonecode { get; set; }


        [StringLength(1)]
        public string Sakhtykar { get; set; }

        public double RemMorOldYear { get; set; }


        [StringLength(4)]
        public string UpdRemMor { get; set; }

        public double? RemMor84 { get; set; }

        [StringLength(13)]
        public string Siba { get; set; }

        [StringLength(15)]
        public string AccNoSh { get; set; }


        [StringLength(1)]
        public string SibaPay { get; set; }

        [StringLength(4)]
        public string RealPlace { get; set; }

        [StringLength(6)]
        public string coupleEmpNo { get; set; }

        [StringLength(13)]
        public string AccNoOld { get; set; }

        [StringLength(20)]
        public string pass1 { get; set; }

        [StringLength(20)]
        public string pass2 { get; set; }

        [StringLength(1)]
        public string Thanks { get; set; }

        [StringLength(4)]
        public string UnitWithoutCostCenter { get; set; }

        [StringLength(6)]
        public string EmpnoNew { get; set; }
        public EmpImage EmpImage { get; set; }
        public Place BirthCity { get; set; }
        public Place IssueCity { get; set; }
        public CodeFile Religion { get; set; }
        public CodeFile EmpTypeDsc { get; set; }
        public OrganUnit UnitPlace { get; set; }
        public OrganUnit RUnitPlace { get; set; }
        public CodeFile Marriage { get; set; }
        public CodeFile National { get; set; }
        public CodeFile NezStat { get; set; }
        public CodeFile LDegree { get; set; }
        public Major LMajor { get; set; }
        public CodeFile InsT { get; set; }
        public CodeFile Blood { get; set; }
        public CodeFile Health { get; set; }
        public CodeFile House { get; set; }
        public ExePostNumber LPost { get; set; }

    }
}
