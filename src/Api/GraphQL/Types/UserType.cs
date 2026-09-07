namespace Api.GraphQL.Types
{
	public class UserType
	{
		public Guid Id { get; set; }
		public string DisplayName { get; set; }
		public string? Email { get; set; }
		public string? FullName { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? LastLoginAt { get; set; }

		// stub: external provider IDs (i.e. OIDC Google, Facebook, etc.)
		public string? GoogleId { get; set; }
	}
}