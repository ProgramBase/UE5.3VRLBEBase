using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECollisionEnabled")]
	public enum ECollisionEnabled : byte
	{
		NoCollision = 0,
		QueryOnly = 1,
		PhysicsOnly = 2,
		QueryAndPhysics = 3,
		ProbeOnly = 4,
		QueryAndProbe = 5,
	}
}