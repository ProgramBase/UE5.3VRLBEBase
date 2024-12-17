using Script.CoreUObject;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.EFrameNumberDisplayFormats")]
	public enum EFrameNumberDisplayFormats : byte
	{
		NonDropFrameTimecode = 0,
		DropFrameTimecode = 1,
		Seconds = 2,
		Frames = 3,
		MAX_Count = 4,
	}
}