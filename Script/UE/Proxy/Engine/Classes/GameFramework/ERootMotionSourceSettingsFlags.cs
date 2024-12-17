using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERootMotionSourceSettingsFlags")]
	public enum ERootMotionSourceSettingsFlags : long
	{
		UseSensitiveLiftoffCheck = 1,
		DisablePartialEndTick = 2,
		IgnoreZAccumulate = 4,
	}
}