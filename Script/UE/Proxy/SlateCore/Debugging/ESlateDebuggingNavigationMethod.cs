using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESlateDebuggingNavigationMethod")]
	public enum ESlateDebuggingNavigationMethod : long
	{
		Unknown = 0,
		Explicit = 1,
		CustomDelegateBound = 2,
		CustomDelegateUnbound = 3,
		NextOrPrevious = 4,
		HitTestGrid = 5,
	}
}