using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESoundWaveLoadingBehavior")]
	public enum ESoundWaveLoadingBehavior : byte
	{
		Inherited = 0,
		RetainOnLoad = 1,
		PrimeOnLoad = 2,
		LoadOnDemand = 3,
		ForceInline = 4,
		Uninitialized = 255,
	}
}