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
    class EmpMilitartyConfig : EntityTypeConfiguration<MilitaryService>
    {
        public EmpMilitartyConfig()
        {
            HasKey(e => new { e.Empno, e.Type, e.StartDate});
            HasRequired(e => e.MilitaryType).WithMany().HasForeignKey(e => e.Type).WillCascadeOnDelete(false);
        }
    }
}
