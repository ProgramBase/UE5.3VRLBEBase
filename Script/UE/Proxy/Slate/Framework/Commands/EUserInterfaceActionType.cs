using Script.CoreUObject;

namespace Script.Slate
{
	[PathName("/Script/Slate.EUserInterfaceActionType")]
	public enum EUserInterfaceActionType : byte
	{
		None = 0,
		Button = 1,
		ToggleButton = 2,
		RadioButton = 3,
		Check = 4,
		CollapsedButton = 5,
	}
}