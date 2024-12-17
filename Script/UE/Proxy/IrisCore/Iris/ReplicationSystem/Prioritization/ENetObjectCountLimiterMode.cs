using Script.CoreUObject;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ENetObjectCountLimiterMode")]
	public enum ENetObjectCountLimiterMode : uint
	{
		RoundRobin = 0,
		Fill = 1,
	}
}