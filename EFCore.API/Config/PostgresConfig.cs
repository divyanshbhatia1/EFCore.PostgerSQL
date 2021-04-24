using Npgsql;

namespace EFCore.API.Config
{
	public class PostgresConfig
	{
		public string Host { get; set; }
		public int Port { get; set; } = 5432;
		public string User { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }

		public string ConnectionString
		{
			get
			{
				NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder
				{
					Host = Host,
					Database = Name,
					Username = User,
					Password = Password,
					Port = Port
				};

				return builder.ConnectionString;
			}
		}
	}
}
