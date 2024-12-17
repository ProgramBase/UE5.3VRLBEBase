using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EButtonClickMethod")]
	public enum EButtonClickMethod : byte
	{
		DownAndUp = 0,
		MouseDown = 1,
		MouseUp = 2,
		PreciseClick = 3,
	}
}