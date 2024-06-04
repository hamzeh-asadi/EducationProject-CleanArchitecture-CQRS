using Education.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Education.Infrastructure.StartupSettings
{
    public class Bootstrapper
    {
        public static void Bootstrap(IServiceCollection service,string connectionString)
        {
            #region context
            service.AddDbContext<EducationContext>(options => options.UseSqlServer(connectionString));
            #endregion
        }
    }
}
