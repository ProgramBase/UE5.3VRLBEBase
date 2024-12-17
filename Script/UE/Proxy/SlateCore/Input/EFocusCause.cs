using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EFocusCause")]
	public enum EFocusCause : long
	{
		Mouse = 0,
		Navigation = 1,
		SetDirectly = 2,
		Cleared = 3,
		OtherWidgetLostFocus = 4,
		WindowActivate = 5,
	}
}