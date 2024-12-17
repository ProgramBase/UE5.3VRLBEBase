using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EParticleCollisionMode")]
	public enum EParticleCollisionMode : byte
	{
		SceneDepth = 0,
		DistanceField = 1,
	}
}