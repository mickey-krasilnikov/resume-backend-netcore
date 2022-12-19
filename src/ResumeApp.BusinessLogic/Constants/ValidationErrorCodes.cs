using ResumeApp.BusinessLogic.Annotations;

namespace ResumeApp.BusinessLogic.Constants
{
	[ErrorCodes]
	public static class ValidationErrorCodes
	{
		public const string CannotBeNullOrEmpty = "CannotBeNullOrEmpty";
		public const string MustBeValidEmailAddress = "MustBeValidEmailAddress";
		public const string MustBeValidFirstName = "MustBeValidFirstName";
		public const string MustBeValidLastName = "MustBeValidLastName";
		public const string MustBeIntegerNumber = "MustBeIntegerNumber";
		public const string MustBeValidDateString = "MustBeValidDateString";
	}
}