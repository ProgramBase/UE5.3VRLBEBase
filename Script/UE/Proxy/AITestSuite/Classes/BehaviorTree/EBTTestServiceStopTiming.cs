using Script.CoreUObject;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.EBTTestServiceStopTiming")]
	public enum EBTTestServiceStopTiming : byte
	{
		DuringBecomeRelevant = 0,
		DuringTick = 1,
		DuringCeaseRelevant = 2,
	}
}