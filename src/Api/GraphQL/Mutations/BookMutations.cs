using Api.GraphQL.Types;

namespace Api.GraphQL.Mutations
{
	public class BookMutations
	{
		public BookType AddBook(string title, string? author, string? isbn, int? publicationYear)
		{
			return new BookType
			{
				Id = Guid.NewGuid(),
				Title = title,
				Author = author,
				ISBN = isbn,
				PublicationYear = publicationYear
			};
		}

		public BookType AddGenreToBook(Guid bookId, Guid genreId)
		{
			return new BookType
			{
				Id = bookId,
				Genres = new List<GenreType>
				{
					new GenreType {
						Id = genreId,
						Name = "Stub"
					}
				}
			};
		}
	}
}