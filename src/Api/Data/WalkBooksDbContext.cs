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
			modelBuilder.Entity<GenreType>(entity =>
			{
				entity.Property(g => g.Medium)
							.HasConversion<string>(); // store enum as text
			});

			// Seed genres from JSON
			var genres = GenreSeed.LoadAll("Data/genres.json");

			// Seed genres
			modelBuilder.Entity<GenreType>().HasData(genres);

			base.OnModelCreating(modelBuilder);
		}
	}
}