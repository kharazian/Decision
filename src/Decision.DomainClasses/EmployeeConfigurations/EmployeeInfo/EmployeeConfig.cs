using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;

namespace Decision.DomainClasses.EmployeeConfigurations
{
    /// <summary>
    /// نشان دهنده مپینگ مربوط به کلاس کارمند
    /// </summary>
    public class EmployeeConfig : EntityTypeConfiguration<Employee>
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public EmployeeConfig()
        {
            HasKey(e => e.Empno);
            HasOptional(e => e.EmpImage).WithRequired().WillCascadeOnDelete(true);
            HasOptional(e => e.BirthCity).WithMany().HasForeignKey(e => e.BirthCityCod).WillCascadeOnDelete(false);
            HasOptional(e => e.IssueCity).WithMany().HasForeignKey(e => e.IssueCityCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Religion).WithMany().HasForeignKey(e => e.ReligionCod).WillCascadeOnDelete(false);
            HasOptional(e => e.EmpTypeDsc).WithMany().HasForeignKey(e => e.EmpType).WillCascadeOnDelete(false);
            HasOptional(e => e.UnitPlace).WithMany().HasForeignKey(e => e.Unit).WillCascadeOnDelete(false);
            HasOptional(e => e.RUnitPlace).WithMany().HasForeignKey(e => e.RealPlace).WillCascadeOnDelete(false);
            HasOptional(e => e.Marriage).WithMany().HasForeignKey(e => e.MarriCod).WillCascadeOnDelete(false);
            HasOptional(e => e.National).WithMany().HasForeignKey(e => e.NationalCod).WillCascadeOnDelete(false);
            HasOptional(e => e.NezStat).WithMany().HasForeignKey(e => e.NezStatCod).WillCascadeOnDelete(false);
            HasOptional(e => e.LDegree).WithMany().HasForeignKey(e => e.LDegreeCod).WillCascadeOnDelete(false);
            HasOptional(e => e.LMajor).WithMany().HasForeignKey(e => e.LMajorCod).WillCascadeOnDelete(false);
            HasOptional(e => e.InsT).WithMany().HasForeignKey(e => e.InsType).WillCascadeOnDelete(false);
            HasOptional(e => e.Blood).WithMany().HasForeignKey(e => e.BloodCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Health).WithMany().HasForeignKey(e => e.HealthCod).WillCascadeOnDelete(false);
            HasOptional(e => e.House).WithMany().HasForeignKey(e => e.HouseCod).WillCascadeOnDelete(false);
            HasOptional(e => e.LPost).WithMany().HasForeignKey(e => new { e.SematCod, e.LPostNoEblagh }).WillCascadeOnDelete(false);

        }
    }
}
