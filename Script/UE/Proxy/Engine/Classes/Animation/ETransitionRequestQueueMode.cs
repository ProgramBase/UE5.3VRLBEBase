using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETransitionRequestQueueMode")]
	public enum ETransitionRequestQueueMode : byte
	{
		Shared = 0,
		Unique = 1,
	}
}