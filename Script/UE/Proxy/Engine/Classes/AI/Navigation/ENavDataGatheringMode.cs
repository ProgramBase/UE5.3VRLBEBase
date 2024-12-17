using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENavDataGatheringMode")]
	public enum ENavDataGatheringMode : byte
	{
		Default = 0,
		Instant = 1,
		Lazy = 2,
	}
}