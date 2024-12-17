using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.EParticleAllocationMode")]
	public enum EParticleAllocationMode : byte
	{
		AutomaticEstimate = 0,
		ManualEstimate = 1,
		FixedCount = 2,
	}
}