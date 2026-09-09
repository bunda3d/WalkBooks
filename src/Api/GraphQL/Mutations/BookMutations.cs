using Api.GraphQL.Types;
using Api.Services;

namespace Api.GraphQL.Mutations
{
	public class BookMutations
	{
		public async Task<BookType> AddBook(
			string title,
			string? author,
			string? isbn,
			int? publicationYear,
			[Service] BookService service,
			CancellationToken ct
		)
		{
			return await service.AddBookAsync(title, author, isbn, publicationYear, ct);
		}

		public async Task<BookType> AddGenreToBook(
				Guid bookId,
				Guid genreId,
				[Service] BookService service,
				CancellationToken ct
		)
		{
			return await service.AddGenreToBookAsync(bookId, genreId, ct);
		}

		public async Task<BookType> RemoveGenreFromBook(
				Guid bookId,
				Guid genreId,
				[Service] BookService service,
				CancellationToken ct
		)
		{
			return await service.RemoveGenreFromBookAsync(bookId, genreId, ct);
		}
	}
}