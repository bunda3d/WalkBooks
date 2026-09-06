namespace Api.GraphQL.Types
{
	public class LibraryType
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }

		public List<BookCopyType> Books { get; set; } = new();
		public List<LibrarySnapshotType> LibrarySnapshots { get; set; } = new();
	}
}