using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESourceBusSendLevelControlMethod")]
	public enum ESourceBusSendLevelControlMethod : byte
	{
		Linear = 0,
		CustomCurve = 1,
		Manual = 2,
	}
}