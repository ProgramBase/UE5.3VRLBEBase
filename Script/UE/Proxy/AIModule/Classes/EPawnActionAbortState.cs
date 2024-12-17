using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPawnActionAbortState")]
	public enum EPawnActionAbortState : byte
	{
		NeverStarted = 0,
		NotBeingAborted = 1,
		MarkPendingAbort = 2,
		LatentAbortInProgress = 3,
		AbortDone = 4,
	}
}