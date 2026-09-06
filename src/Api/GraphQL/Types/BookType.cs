namespace Api.GraphQL.Types
{
	public class BookType
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string? Author { get; set; }
		public string? ISBN { get; set; }
		public int? PublicationYear { get; set; }
		public string? Genre { get; set; }
		public string? CoverImageUrl { get; set; }
	}
}