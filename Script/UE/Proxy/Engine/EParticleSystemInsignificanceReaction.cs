using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleSystemInsignificanceReaction")]
	public enum EParticleSystemInsignificanceReaction : byte
	{
		Auto = 0,
		Complete = 1,
		DisableTick = 2,
		DisableTickAndKill = 3,
		Num = 4,
	}
}