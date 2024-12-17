using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPawnActionMoveMode")]
	public enum EPawnActionMoveMode : long
	{
		UsePathfinding = 0,
		StraightLine = 1,
	}
}