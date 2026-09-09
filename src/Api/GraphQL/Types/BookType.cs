namespace Api.GraphQL.Types
{
	public class BookType
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string? Author { get; set; }
		public string? ISBN { get; set; }
		public int? PublicationYear { get; set; }
		public string? CoverImageUrl { get; set; }

		// nav property will be referenced to GenreType's BookType nav property and indicate a many-to-many relation,
		// then EF creates a join table (appropriate data structure for this relation)
		public List<GenreType> Genres { get; set; } = new();
	}
}