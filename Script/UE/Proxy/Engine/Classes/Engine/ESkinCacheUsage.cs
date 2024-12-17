using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESkinCacheUsage")]
	public enum ESkinCacheUsage : byte
	{
		Auto = 0,
		Disabled = 255,
		Enabled = 1,
	}
}