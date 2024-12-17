using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EVirtualKeyboardTrigger")]
	public enum EVirtualKeyboardTrigger : byte
	{
		OnFocusByPointer = 0,
		OnAllFocusEvents = 1,
	}
}