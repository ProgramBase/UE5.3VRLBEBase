using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.EBodyCollisionResponse")]
	public enum EBodyCollisionResponse : byte
	{
		BodyCollision_Enabled = 0,
		BodyCollision_Disabled = 1,
	}
}