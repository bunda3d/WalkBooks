using Api.GraphQL.Types;

namespace Api.GraphQL.Mutations
{
	public class BookCopyMutations
	{
		public BookCopyType AddBookCopy(Guid bookId, Guid libraryId, bool isAvailable)
		{
			return new BookCopyType
			{
				Id = Guid.NewGuid(),
				BookId = bookId,
				LibraryId = libraryId,
				Condition = null,
				IsAvailable = isAvailable
			};
		}

		public BookCopyType RemoveBookCopy(Guid copyId)
		{
			return new BookCopyType
			{
				Id = copyId,
				BookId = Guid.Empty,
				LibraryId = Guid.Empty,
				Condition = null,
				IsAvailable = false
			};
		}
	}
}