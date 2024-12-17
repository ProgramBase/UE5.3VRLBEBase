using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleBurstMethod")]
	public enum EParticleBurstMethod : byte
	{
		EPBM_Instant = 0,
		EPBM_Interpolated = 1,
	}
}