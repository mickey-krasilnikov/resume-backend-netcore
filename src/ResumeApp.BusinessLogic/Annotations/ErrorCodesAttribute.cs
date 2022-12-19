namespace ResumeApp.BusinessLogic.Annotations
{
	/// <summary>
	/// Indicates that the class upon which this attribute is applied defines error codes which may be included in a
	/// response. Any calling applications need to be aware of such codes in order to transform them to human-readable format.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class ErrorCodesAttribute : Attribute { }
}