using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EWidgetTimingPolicy")]
	public enum EWidgetTimingPolicy : byte
	{
		RealTime = 0,
		GameTime = 1,
	}
}