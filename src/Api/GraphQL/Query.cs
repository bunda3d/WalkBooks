using Api.Data;
using Api.GraphQL.Types;

namespace Api.GraphQL
{
	public class Query
	{
		public IEnumerable<LibraryType> GetLibraries() =>
			new List<LibraryType>(); // stub for now...

		public IEnumerable<BookType> GetBooks() =>
			new List<BookType>(); // stub for now...

		public IEnumerable<GenreType> GetGenres() =>
			GenreSeed.List; // static list for now...
	}
}