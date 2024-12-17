using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAnimGroupRole")]
	public enum EAnimGroupRole : byte
	{
		CanBeLeader = 0,
		AlwaysFollower = 1,
		AlwaysLeader = 2,
		TransitionLeader = 3,
		TransitionFollower = 4,
	}
}