using Script.CoreUObject;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.EStartMode")]
	public enum EStartMode : byte
	{
		Timed = 0,
		Triggered = 1,
	}
}