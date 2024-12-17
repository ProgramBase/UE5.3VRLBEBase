using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EIndirectLightingCacheQuality")]
	public enum EIndirectLightingCacheQuality : byte
	{
		ILCQ_Off = 0,
		ILCQ_Point = 1,
		ILCQ_Volume = 2,
	}
}