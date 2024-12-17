using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPathFollowingAction")]
	public enum EPathFollowingAction : byte
	{
		Error = 0,
		NoMove = 1,
		DirectMove = 2,
		PartialPath = 3,
		PathToGoal = 4,
	}
}