using Api.GraphQL.Mutations;

namespace Api.GraphQL
{
	public class Mutation
	{
		public LibraryMutations Library => new();
		public BookMutations Book => new();
		public BookCopyMutations BookCopy => new();
		public LibrarySnapshotMutations LibrarySnapshot => new();
		public GenreMutations Genre => new();
		public UserMutations User => new();
	}
}