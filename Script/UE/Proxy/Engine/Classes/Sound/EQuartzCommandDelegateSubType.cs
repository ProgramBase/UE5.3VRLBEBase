using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EQuartzCommandDelegateSubType")]
	public enum EQuartzCommandDelegateSubType : byte
	{
		CommandOnFailedToQueue = 0,
		CommandOnQueued = 1,
		CommandOnCanceled = 2,
		CommandOnAboutToStart = 3,
		CommandOnStarted = 4,
		Count = 5,
	}
}