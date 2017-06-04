using MiApp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MiApp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MiAppDbContext _context;

        public InitialHostDbBuilder(MiAppDbContext context)
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
