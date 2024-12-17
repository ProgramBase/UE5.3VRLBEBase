using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EGenericAICheck")]
	public enum EGenericAICheck : long
	{
		Less = 0,
		LessOrEqual = 1,
		Equal = 2,
		NotEqual = 3,
		GreaterOrEqual = 4,
		Greater = 5,
		IsTrue = 6,
	}
}