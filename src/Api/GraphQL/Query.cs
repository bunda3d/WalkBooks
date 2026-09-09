using Api.GraphQL.Types;
using Api.Services;

namespace Api.GraphQL
{
	public class Query
	{
		public IEnumerable<LibraryType> GetLibraries() =>
			new List<LibraryType>(); // stub for now...

		public Task<List<BookType>> GetBooks(
				[Service] BookService service,
				CancellationToken ct)
				=> service.GetBooksAsync(ct);

		public Task<List<GenreType>> GetGenres(
				GenreMedium medium,
				[Service] GenreService service,
				CancellationToken ct)
				=> service.GetGenresAsync(medium, ct);
	}
}