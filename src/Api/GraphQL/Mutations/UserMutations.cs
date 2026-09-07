using Api.GraphQL.Types;

namespace Api.GraphQL.Mutations
{
	public class UserMutations
	{
		public UserType CreateUser(string displayName, string email)
		{
			return new UserType
			{
				Id = Guid.NewGuid(),
				DisplayName = displayName,
				Email = email
			};
		}
	}
}