using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EButtonTouchMethod")]
	public enum EButtonTouchMethod : byte
	{
		DownAndUp = 0,
		Down = 1,
		PreciseTap = 2,
	}
}