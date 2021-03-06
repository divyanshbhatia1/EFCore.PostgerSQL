using EFCore.API.Config;
using EFCore.Data.PostgreSQL;
using EFCore.Data.SQLServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EFCore.API
{
	public class Startup
	{
		public IConfiguration Configuration { get; set; }
		private readonly PostgresConfig _postgresConfig;
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
			_postgresConfig = Configuration.GetSection("PostgresConfig").Get<PostgresConfig>();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			//services.ConfigurePostgreSQLDbContext(_postgresConfig.ConnectionString);
			services.ConfigureSQLServerDbContext(Configuration.GetConnectionString("SQLServerConnection"));
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
