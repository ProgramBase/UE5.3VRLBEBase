using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENavPathEvent")]
	public enum ENavPathEvent : byte
	{
		Cleared = 0,
		NewPath = 1,
		UpdatedDueToGoalMoved = 2,
		UpdatedDueToNavigationChanged = 3,
		Invalidated = 4,
		RePathFailed = 5,
		MetaPathUpdate = 6,
		Custom = 7,
	}
}