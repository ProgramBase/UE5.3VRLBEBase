using Script.CoreUObject;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.ETimedDataInputEvaluationType")]
	public enum ETimedDataInputEvaluationType : long
	{
		None = 0,
		Timecode = 1,
		PlatformTime = 2,
	}
}