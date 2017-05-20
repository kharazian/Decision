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
    /// نشان دهنده مپینگ مربوط به کلاس ارگان
    /// </summary>
    public class OrganUnitConfig : EntityTypeConfiguration<OrganUnit>
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public OrganUnitConfig()
        {
            HasKey(e => e.Unit);           
            HasRequired(e => e.Manage1).WithMany().HasForeignKey(e => new { e.Manage1No, e.Manage2No }).WillCascadeOnDelete(false);
            HasRequired(e => e.Manage2).WithMany().HasForeignKey(e => new { e.Manage1No, e.Manage2No }).WillCascadeOnDelete(false);

        }
    }
}
