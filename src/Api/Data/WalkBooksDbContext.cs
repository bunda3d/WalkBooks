using Api.GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
	public class WalkBooksDbContext : DbContext
	{
		public WalkBooksDbContext(DbContextOptions<WalkBooksDbContext> options)
			: base(options)
		{
		}

		public DbSet<LibraryType> Libraries => Set<LibraryType>();
		public DbSet<BookType> Books => Set<BookType>();
		public DbSet<BookCopyType> BookCopies => Set<BookCopyType>();
		public DbSet<GenreType> Genres => Set<GenreType>();
		public DbSet<UserType> Users => Set<UserType>();
		public DbSet<LibrarySnapshotType> LibrarySnapshots => Set<LibrarySnapshotType>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Seed genres from JSON
			var genres = GenreSeed.List;
			modelBuilder.Entity<GenreType>().HasData(genres);

			base.OnModelCreating(modelBuilder);
		}
	}
}