using Script.CoreUObject;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.ETakeRecorderState")]
	public enum ETakeRecorderState : byte
	{
		CountingDown = 0,
		PreRecord = 1,
		TickingAfterPre = 2,
		Started = 3,
		Stopped = 4,
		Cancelled = 5,
	}
}