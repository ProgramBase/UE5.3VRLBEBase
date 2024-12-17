using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleSystemUpdateMode")]
	public enum EParticleSystemUpdateMode : byte
	{
		EPSUM_RealTime = 0,
		EPSUM_FixedTime = 1,
	}
}