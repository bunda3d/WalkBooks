using Api.GraphQL.Types;

namespace Api.GraphQL.Mutations
{
	public class LibrarySnapshotMutations
	{
		public LibrarySnapshotType AddLibrarySnapshot(Guid libraryId, string imageUrl)
		{
			return new LibrarySnapshotType
			{
				Id = Guid.NewGuid(),
				LibraryId = libraryId,
				ImageUrl = imageUrl,
				DateTaken = DateTime.UtcNow,
				AvailableBooks = 0
			};
		}
	}
}