namespace Api.GraphQL.Types
{
	public class LibrarySnapshotType
	{
		public Guid Id { get; set; }
		public Guid LibraryId { get; set; }

		public string ImageUrl { get; set; }
		public DateTime DateTaken { get; set; }
		public string? TakenByUser { get; set; }

		public int TotalBooks { get; set; }
		public int AvailableBooks { get; set; }
		public int RemovedBooks { get; set; }
	}
}