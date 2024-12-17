using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERayTracingGlobalIlluminationType")]
	public enum ERayTracingGlobalIlluminationType : byte
	{
		Disabled = 0,
		BruteForce = 1,
		FinalGather = 2,
	}
}