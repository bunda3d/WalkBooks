namespace Api.GraphQL.Types
{
	public class UserContributionType
	{
		public Guid Id { get; set; }
		public string UserId { get; set; } // stub: Azure AD B2C or anonymous token
		public string Action { get; set; } // e.g., "AddBook", "RemoveBook", "AddLibrary", "AddSnapshot", etc.
		public DateTime Timestamp { get; set; }

		public Guid? LibraryId { get; set; }
		public Guid? BookCopyId { get; set; }
	}
}