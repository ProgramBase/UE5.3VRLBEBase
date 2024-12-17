using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPawnActionEventType")]
	public enum EPawnActionEventType : long
	{
		Invalid = 0,
		FailedToStart = 1,
		InstantAbort = 2,
		FinishedAborting = 3,
		FinishedExecution = 4,
		Push = 5,
	}
}