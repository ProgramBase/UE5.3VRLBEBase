using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleCollisionComplete")]
	public enum EParticleCollisionComplete : byte
	{
		EPCC_Kill = 0,
		EPCC_Freeze = 1,
		EPCC_HaltCollisions = 2,
		EPCC_FreezeTranslation = 3,
		EPCC_FreezeRotation = 4,
		EPCC_FreezeMovement = 5,
	}
}