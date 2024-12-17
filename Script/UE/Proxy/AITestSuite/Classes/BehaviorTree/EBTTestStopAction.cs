using Script.CoreUObject;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.EBTTestStopAction")]
	public enum EBTTestStopAction : byte
	{
		StopTree = 0,
		UnInitialize = 1,
		Cleanup = 2,
		Restart_ForceReevaluateRootNode = 3,
		Restart_Complete = 4,
		StartTree = 5,
	}
}