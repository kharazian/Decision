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
    class PlaceEmpConfig : EntityTypeConfiguration<PlaceEmp>
    {
        public PlaceEmpConfig()
        {
            HasKey(e => new { e.HokmYear, e.Seq});
            HasOptional(e => e.EmployeeType).WithMany().HasForeignKey(e => e.EmpType).WillCascadeOnDelete(false);
            HasOptional(e => e.RealUnit).WithMany().HasForeignKey(e => e.RealPlace).WillCascadeOnDelete(false);
            HasOptional(e => e.CostUnit).WithMany().HasForeignKey(e => e.Unit).WillCascadeOnDelete(false);

        }
    }
}
