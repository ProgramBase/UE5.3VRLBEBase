using Script.CoreUObject;

namespace Script.AutomationController
{
	[PathName("/Script/AutomationController.EComparisonFileTypes")]
	public enum EComparisonFileTypes : byte
	{
		Unapproved = 0,
		Approved = 1,
		Difference = 2,
	}
}