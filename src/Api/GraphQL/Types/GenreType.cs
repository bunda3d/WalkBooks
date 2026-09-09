namespace Api.GraphQL.Types
{
	public enum GenreMedium
	{
		Book = 1,
		Magazine = 2,
		CD_Audiobook = 3,
		CD_Music = 4,
		DVD_Movie = 5,
		DVD_TvShow = 6,
		Game_Board = 7,
		Game_Video = 8
	}

	public class GenreType
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public GenreMedium Medium { get; set; }
	}
}