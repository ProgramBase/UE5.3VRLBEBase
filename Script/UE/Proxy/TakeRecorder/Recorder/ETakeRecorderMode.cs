using Script.CoreUObject;

namespace Script.TakeRecorder
{
	[PathName("/Script/TakeRecorder.ETakeRecorderMode")]
	public enum ETakeRecorderMode : byte
	{
		RecordNewSequence = 0,
		RecordIntoSequence = 1,
	}
}