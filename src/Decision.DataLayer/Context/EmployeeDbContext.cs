using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using EFSecondLevelCache;
using EntityFramework.DynamicFilters;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Decision.DomainClasses.EmployeeEntities;

using Decision.Utility;
using EntityFramework.DynamicFilters;

namespace Decision.DataLayer.Context
{
    public partial class EmployeeDbContext : DbContext
    {
        #region Constrans
        protected const string ConcurrencyMessage = "مقادیر در سمت بانک اطلاعاتی تغییر کرده‌اند. لطفا صفحه را ریفرش کنید.";
        #endregion

        #region Fields        
        private List<Type> _types;
        #endregion

        #region Ctor
        public EmployeeDbContext() : base("EmployeeDbContext")
        {
            _types = typeof(Employee).Assembly.GetTypes()
                        .Where(type => type.BaseType != null &&
                                       type.Namespace == "Decision.DomainClasses.EmployeeEntities")
                        .ToList();
            Database.Initialize(false);
        }
        #endregion

        #region Override OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            DbInterception.Add(new YeKeInterceptor());

            // for full text search  DbInterception.Add(new FtsInterceptor());
            //modelBuilder.Ignore<BaseEntity>();

            modelBuilder.Configurations.AddFromAssembly(typeof(Employee).Assembly);
            LoadEntities(typeof(Employee).Assembly, modelBuilder, "Decision.DomainClasses.EmployeeEntities");

            //modelBuilder.Filter("Tenant", (Employee e, String empno) => (e.Empno==empno), () => "Admin");
            modelBuilder.Filter("Tenant", (ITenant e, List<string> empno) => (empno.Contains(e.Empno)), () => new List<string>());
            //modelBuilder.Filter("BlogContainsTest", (BlogEntry b, List<DateTime> valueList) => valueList.Contains(b.DateValue.Value), () => values);
        }

        #endregion

        #region RejectChanges
        public void RejectChanges()
        {
            foreach (var entry in this.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;

                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        #endregion

        #region SaveChanges
        public int SaveAllChanges(bool invalidateCacheDependencies = true, Guid? auditUserId = null)
        {
            if (auditUserId.HasValue)
                UpdateAuditFields(auditUserId.Value);
            var result = SaveChanges();
            if (!invalidateCacheDependencies) return result;
            var changedEntityNames = GetChangedEntityNames();
            new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);
            return result;
        }
        public Task<int> SaveAllChangesAsync(bool invalidateCacheDependencies = true, Guid? auditUserId = null)
        {
            if (auditUserId.HasValue)
                UpdateAuditFields(auditUserId.Value);
            var result = SaveChangesAsync();
            if (!invalidateCacheDependencies) return result;
            var changedEntityNames = GetChangedEntityNames();
            new EFCacheServiceProvider().InvalidateCacheDependencies(changedEntityNames);

            return result;
        }

        #endregion

        #region UpdateAuditFields
        private void UpdateAuditFields(Guid auditUserId)
        {
        }
        #endregion

        #region PrivateMethods
        private string[] GetChangedEntityNames()
        {
            return ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added ||
                            x.State == EntityState.Modified ||
                            x.State == EntityState.Deleted)
                .Select(x => ObjectContext.GetObjectType(x.Entity.GetType()).FullName)
                .Distinct()
                .ToArray();
        }

        private static void LoadEntities(Assembly asm, DbModelBuilder modelBuilder, string nameSpace)
        {
            var entityTypes = asm.GetTypes()
                .Where(type => type.BaseType != null &&
                               type.Namespace == nameSpace &&
                               type.BaseType == null)
                .ToList();

            entityTypes.ForEach(modelBuilder.RegisterEntityType);
        }
        #endregion

        public Boolean IsEntity(Type entity)
        {
            if (_types.Where(x => x.Name == entity.Name).Count() > 0)
            {
                return true;
            }
            return false;
        }
        #region Dispose
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing); //فقط تعريف شده تا يك برك پوينت در اينجا قرار داده شود براي آزمايش فراخواني آن
        }
        #endregion

    }
}
