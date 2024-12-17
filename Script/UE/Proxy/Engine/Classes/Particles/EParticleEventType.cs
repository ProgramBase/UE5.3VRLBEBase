using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleEventType")]
	public enum EParticleEventType : byte
	{
		EPET_Any = 0,
		EPET_Spawn = 1,
		EPET_Death = 2,
		EPET_Collision = 3,
		EPET_Burst = 4,
		EPET_Blueprint = 5,
	}
}