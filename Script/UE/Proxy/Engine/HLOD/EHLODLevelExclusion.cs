using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EHLODLevelExclusion")]
	public enum EHLODLevelExclusion : byte
	{
		HLOD0 = 1,
		HLOD1 = 2,
		HLOD2 = 4,
		HLOD3 = 8,
		HLOD4 = 16,
		HLOD5 = 32,
		HLOD6 = 64,
		HLOD7 = 128,
	}
}