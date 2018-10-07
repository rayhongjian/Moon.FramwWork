using Moon.FrameWork.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Moon.FrameWork.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly FrameWorkDbContext _context;

        public InitialHostDbBuilder(FrameWorkDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
