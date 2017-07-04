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
    class EmpDegreeConfig : EntityTypeConfiguration<EmpDegree>
    {
        public EmpDegreeConfig()
        {
            HasKey(e => new { e.Empno, e.DegreeCod, e.DegreeDate});
            HasRequired(e => e.Degree).WithMany().HasForeignKey(e => e.DegreeCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Major).WithMany().HasForeignKey(e => e.MajorCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Country).WithMany().HasForeignKey(e => e.CntyCod).WillCascadeOnDelete(false);
            HasOptional(e => e.School).WithMany().HasForeignKey(e => e.SchoolNam).WillCascadeOnDelete(false);
        }
    }
}
