using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleSystemLODMethod")]
	public enum ParticleSystemLODMethod : byte
	{
		PARTICLESYSTEMLODMETHOD_Automatic = 0,
		PARTICLESYSTEMLODMETHOD_DirectSet = 1,
		PARTICLESYSTEMLODMETHOD_ActivateAutomatic = 2,
	}
}