using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ESimulationTiming")]
	public enum ESimulationTiming : byte
	{
		Default = 0,
		Synchronous = 1,
		Deferred = 2,
	}
}