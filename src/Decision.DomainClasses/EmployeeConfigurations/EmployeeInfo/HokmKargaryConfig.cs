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
    class HokmKargaryConfig : EntityTypeConfiguration<HokmKargary>
    {
        public HokmKargaryConfig()
        {
            HasKey(e => new { e.HokmYear, e.Seq });
            HasOptional(e => e.HokmT).WithMany().HasForeignKey(e => e.HokmType).WillCascadeOnDelete(false);
            HasOptional(e => e.Degree).WithMany().HasForeignKey(e => e.DegreeCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Major).WithMany().HasForeignKey(e => e.MajorCod).WillCascadeOnDelete(false);
            HasOptional(e => e.Married).WithMany().HasForeignKey(e => e.MarriCod).WillCascadeOnDelete(false);
        }
    }
}
