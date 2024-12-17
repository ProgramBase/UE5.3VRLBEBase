using Script.CoreUObject;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.ESpriteCollisionMode")]
	public enum ESpriteCollisionMode : byte
	{
		None = 0,
		Use2DPhysics = 1,
		Use3DPhysics = 2,
	}
}