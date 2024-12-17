using Script.CoreUObject;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.EFlipbookCollisionMode")]
	public enum EFlipbookCollisionMode : byte
	{
		NoCollision = 0,
		FirstFrameCollision = 1,
		EachFrameCollision = 2,
	}
}