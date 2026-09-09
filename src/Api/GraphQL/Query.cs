using Api.Data;
using Api.GraphQL.Types;
using Api.Services;

namespace Api.GraphQL
{
	public class Query
	{
		public IEnumerable<LibraryType> GetLibraries() =>
			new List<LibraryType>(); // stub for now...

		public IEnumerable<BookType> GetBooks() =>
			new List<BookType>(); // stub for now...

		public Task<List<GenreType>> GetGenres(
			GenreMedium medium,
			[Service] GenreService service,
			CancellationToken ct
		) => service.GetGenresAsync(medium, ct);
	}
}