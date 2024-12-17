using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleSystemOcclusionBoundsMethod")]
	public enum EParticleSystemOcclusionBoundsMethod : byte
	{
		EPSOBM_None = 0,
		EPSOBM_ParticleBounds = 1,
		EPSOBM_CustomBounds = 2,
	}
}