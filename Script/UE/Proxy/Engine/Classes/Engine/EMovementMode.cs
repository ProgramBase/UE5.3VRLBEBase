using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMovementMode")]
	public enum EMovementMode : byte
	{
		MOVE_None = 0,
		MOVE_Walking = 1,
		MOVE_NavWalking = 2,
		MOVE_Falling = 3,
		MOVE_Swimming = 4,
		MOVE_Flying = 5,
		MOVE_Custom = 6,
	}
}