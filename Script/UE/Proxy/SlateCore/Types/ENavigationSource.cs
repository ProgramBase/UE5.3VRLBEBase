using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ENavigationSource")]
	public enum ENavigationSource : long
	{
		FocusedWidget = 0,
		WidgetUnderCursor = 1,
	}
}