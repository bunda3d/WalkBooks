using Api.GraphQL.Types;

namespace Api.GraphQL.Mutations
{
	public class GenreMutations
	{
		public GenreType AddGenre(string name)
		{
			return new GenreType
			{
				Id = Guid.NewGuid(),
				Name = name
			};
		}
	}
}