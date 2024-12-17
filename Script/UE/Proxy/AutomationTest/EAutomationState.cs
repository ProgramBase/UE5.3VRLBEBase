using Script.CoreUObject;

namespace Script.AutomationTest
{
	[PathName("/Script/AutomationTest.EAutomationState")]
	public enum EAutomationState : byte
	{
		NotRun = 0,
		InProcess = 1,
		Fail = 2,
		Success = 3,
		Skipped = 4,
	}
}