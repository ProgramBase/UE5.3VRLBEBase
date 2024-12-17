using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESendLevelControlMethod")]
	public enum ESendLevelControlMethod : byte
	{
		Linear = 0,
		CustomCurve = 1,
		Manual = 2,
	}
}