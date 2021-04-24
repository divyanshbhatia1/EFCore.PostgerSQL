using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.Data.PostgreSQL
{
	public static class ServiceExtensions
	{
		public static void ConfigureDbContext(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<LibraryContext>(
				x => x.UseNpgsql(connectionString));
		}
	}
}
