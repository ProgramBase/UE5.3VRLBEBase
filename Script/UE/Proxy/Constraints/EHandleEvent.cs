using Script.CoreUObject;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.EHandleEvent")]
	public enum EHandleEvent : long
	{
		LocalTransformUpdated = 0,
		GlobalTransformUpdated = 1,
		ComponentUpdated = 2,
		Max = 3,
	}
}