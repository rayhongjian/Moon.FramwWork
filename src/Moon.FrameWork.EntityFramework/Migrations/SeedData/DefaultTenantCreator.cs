using System.Linq;
using Moon.FrameWork.EntityFramework;
using Moon.FrameWork.MultiTenancy;

namespace Moon.FrameWork.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly FrameWorkDbContext _context;

        public DefaultTenantCreator(FrameWorkDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
