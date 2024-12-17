using Script.CoreUObject;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.EBPConditionType")]
	public enum EBPConditionType : int
	{
		NoCondition = 0,
		TrueCondition = 1,
		FalseCondition = 2,
	}
}