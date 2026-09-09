namespace Api.GraphQL.Types
{
	public enum GenreMedium
	{
		Book = 1,
		Magazine = 2,
		CD_Audiobook = 3,
		CD_Music = 4,
		DVD_Movie = 5,
		DVD_Show = 6,
		Game_Board = 7,
		Game_Video = 8
	}

	public class GenreType
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public GenreMedium Medium { get; set; }

		// nav property will be referenced to BookType's GenreType nav property and indicate a many-to-many relation,
		// then EF creates a join table (appropriate data structure for this relation)
		public List<BookType> Books { get; set; } = new();
	}
}