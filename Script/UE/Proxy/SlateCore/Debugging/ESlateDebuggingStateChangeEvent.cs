using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESlateDebuggingStateChangeEvent")]
	public enum ESlateDebuggingStateChangeEvent : long
	{
		MouseCaptureGained = 0,
		MouseCaptureLost = 1,
	}
}