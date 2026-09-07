using Api.GraphQL.Types;

namespace Api.GraphQL.Mutations
{
	public class LibraryMutations
	{
		public LibraryType AddLibrary(string name, string? address, double latitude, double longitude)
		{
			return new LibraryType
			{
				Id = Guid.NewGuid(),
				Name = name,
				Address = address,
				Latitude = latitude,
				Longitude = longitude
			};
		}
	}
}