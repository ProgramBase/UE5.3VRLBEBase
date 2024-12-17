using Script.CoreUObject;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.EBTTestTaskStopTiming")]
	public enum EBTTestTaskStopTiming : byte
	{
		DuringExecute = 0,
		DuringTick = 1,
		DuringAbort = 2,
		DuringFinish = 3,
	}
}