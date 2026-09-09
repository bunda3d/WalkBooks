using Api.Data;
using Api.GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace Api.Services
{
	public class BookService
	{
		private readonly WalkBooksDbContext _db;

		public BookService(WalkBooksDbContext db)
		{
			_db = db;
		}

		public async Task<BookType> AddBookAsync(
			string title,
			string? author,
			string? isbn,
			int? publicationYear,
			CancellationToken ct
		)
		{
			var book = new BookType
			{
				Id = Guid.NewGuid(),
				Title = title,
				Author = author,
				ISBN = isbn,
				PublicationYear = publicationYear
			};

			_db.Books.Add(book);
			await _db.SaveChangesAsync(ct);

			return book;
		}

		public Task<List<BookType>> GetBooksAsync(CancellationToken ct)
		{
			return _db.Books
				.Include(b => b.Genres)
				.ToListAsync(ct);
		}

		public async Task<BookType> AddGenreToBookAsync(Guid bookId, Guid genreId, CancellationToken ct)
		{
			var book = await _db.Books
				.Include(b => b.Genres)
				.FirstOrDefaultAsync(b => b.Id == bookId, ct);
			var genre = await _db.Genres.FindAsync([genreId], ct);

			if (book is null || genre is null)
				throw new Exception("Book or Genre not found via AddGenreToBookAsync.");

			book.Genres.Add(genre);
			await _db.SaveChangesAsync(ct);

			return book;
		}

		public async Task<BookType> RemoveGenreFromBookAsync(Guid bookId, Guid genreId, CancellationToken ct)
		{
			var book = await _db.Books
				.Include(b => b.Genres)
				.FirstOrDefaultAsync(b => b.Id == bookId, ct);
			var genre = await _db.Genres.FindAsync([genreId], ct);

			if (book is null || genre is null)
				throw new Exception("Book or Genre not found via RemoveGenreFromBookAsync.");

			book.Genres.Remove(genre);
			await _db.SaveChangesAsync(ct);

			return book;
		}
	}
}