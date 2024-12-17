using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleSourceSelectionMethod")]
	public enum EParticleSourceSelectionMethod : byte
	{
		EPSSM_Random = 0,
		EPSSM_Sequential = 1,
	}
}