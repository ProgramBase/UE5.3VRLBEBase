using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EButtonPressMethod")]
	public enum EButtonPressMethod : byte
	{
		DownAndUp = 0,
		ButtonPress = 1,
		ButtonRelease = 2,
	}
}