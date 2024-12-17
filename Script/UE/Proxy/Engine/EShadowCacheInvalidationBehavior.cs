using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EShadowCacheInvalidationBehavior")]
	public enum EShadowCacheInvalidationBehavior : byte
	{
		Auto = 0,
		Always = 1,
		Rigid = 2,
		Static = 3,
	}
}