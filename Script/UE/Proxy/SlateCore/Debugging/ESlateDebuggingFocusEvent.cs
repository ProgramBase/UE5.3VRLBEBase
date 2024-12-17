using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESlateDebuggingFocusEvent")]
	public enum ESlateDebuggingFocusEvent : long
	{
		FocusChanging = 0,
		FocusLost = 1,
		FocusReceived = 2,
	}
}