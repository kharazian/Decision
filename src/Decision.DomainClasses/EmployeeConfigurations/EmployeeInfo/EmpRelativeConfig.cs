using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decision.DomainClasses.EmployeeEntities;

namespace Decision.DomainClasses.EmployeeConfigurations.EmployeeInfo
{
    class EmpRelativeConfig : EntityTypeConfiguration<EmpRelative>
    {
        public EmpRelativeConfig()
        {
            HasKey(e => new { e.Empno, e.ReltypeCod, e.RelSequence });
            HasRequired(e => e.Reltype).WithMany().HasForeignKey(e => e.ReltypeCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Sex).WithMany().HasForeignKey(e => e.SexCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Helath).WithMany().HasForeignKey(e => e.HealthCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Mariage).WithMany().HasForeignKey(e => e.MarriCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Degree).WithMany().HasForeignKey(e => e.DegreeCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Major).WithMany().HasForeignKey(e => e.MajorCod).WillCascadeOnDelete(false);
            HasMany(e => e.Bimes).WithRequired(e => e.empRelation).HasForeignKey(e => new { e.Empno, e.RelTypeCod, e.RelSequence }).WillCascadeOnDelete(false);

        }
    }
}
