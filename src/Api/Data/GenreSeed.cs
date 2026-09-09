using Api.GraphQL.Types;
using System.Text.Json;

namespace Api.Data
{
	public class GenreSeed
	{
		public static IReadOnlyList<GenreType> LoadAll(string jsonPath)
		{
			var json = File.ReadAllText(jsonPath);
			using var doc = JsonDocument.Parse(json);
			var root = doc.RootElement.GetProperty("genres");
			var all = new List<GenreType>();

			foreach (var category in root.EnumerateObject())
			{
				var mediumName = category.Name.Replace("-", "_", StringComparison.OrdinalIgnoreCase);
				var medium = Enum.Parse<GenreMedium>(mediumName, ignoreCase: true);

				foreach (var g in category.Value.EnumerateArray())
				{
					all.Add(new GenreType
					{
						Id = Guid.Parse(g.GetProperty("id").GetString()!),
						Name = g.GetProperty("name").GetString()!,
						Medium = medium
					});
				}
			}

			return all;
		}
	}
}