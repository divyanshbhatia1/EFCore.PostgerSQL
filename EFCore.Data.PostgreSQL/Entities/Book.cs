﻿namespace EFCore.Data.PostgreSQL.Entities
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Summary { get; set; }
		public int AuthorId { get; set; }
		public Author Author { get; set; }
	}
}
