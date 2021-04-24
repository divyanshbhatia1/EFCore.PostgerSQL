using EFCore.Data.PostgreSQL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data.PostgreSQL
{
	public class LibraryContext : DbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }

		public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
		{ }
	}
}
