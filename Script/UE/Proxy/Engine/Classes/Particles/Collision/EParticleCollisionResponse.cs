using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleCollisionResponse")]
	public enum EParticleCollisionResponse : byte
	{
		Bounce = 0,
		Stop = 1,
		Kill = 2,
	}
}