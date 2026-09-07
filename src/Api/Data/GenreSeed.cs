using Api.GraphQL.Types;
using System.Text.Json;

namespace Api.Data
{
	public class GenreSeed
	{
		public static List<GenreType> List { get; private set; } = new();

		public static void LoadBookGenres(string jsonPath)
		{
			var json = File.ReadAllText(jsonPath);

			using var doc = JsonDocument.Parse(json);
			var root = doc.RootElement;

			var bookGenres = root
				.GetProperty("genres")
				.GetProperty("book")
				.EnumerateArray()
				.Select(g => new GenreType
				{
					Id = Guid.NewGuid(),
					Name = g.GetString()!
				})
				.ToList();

			List = bookGenres;
		}
	}
}