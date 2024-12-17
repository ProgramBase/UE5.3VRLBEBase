using Script.CoreUObject;

namespace Script.CacheTrackRecorder
{
	[PathName("/Script/CacheTrackRecorder.ECacheTrackRecorderState")]
	public enum ECacheTrackRecorderState : byte
	{
		Starting = 0,
		PreRecord = 1,
		TickingAfterPre = 2,
		Started = 3,
		Stopped = 4,
		Cancelled = 5,
	}
}