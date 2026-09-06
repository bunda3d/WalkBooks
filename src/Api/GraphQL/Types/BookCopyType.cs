namespace Api.GraphQL.Types
{
	public class BookCopyType
	{
		public Guid Id { get; set; }
		public Guid BookId { get; set; }
		public Guid LibraryId { get; set; }
		public string? Condition { get; set; }

		public bool IsAvailable { get; set; }
		public DateTime? RemovedAt { get; set; }

		public BookType? Book { get; set; }
	}
}