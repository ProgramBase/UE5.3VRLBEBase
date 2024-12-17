using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENavDataGatheringModeConfig")]
	public enum ENavDataGatheringModeConfig : byte
	{
		Invalid = 0,
		Instant = 1,
		Lazy = 2,
	}
}