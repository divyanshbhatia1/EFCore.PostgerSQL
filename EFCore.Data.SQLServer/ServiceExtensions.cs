using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.Data.SQLServer
{
	public static class ServiceExtensions
	{
		public static void ConfigureSQLServerDbContext(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<LibraryContext>(
				x => x.UseSqlServer(connectionString));
		}
	}
}
