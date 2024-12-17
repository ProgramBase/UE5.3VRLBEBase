using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTestScoreOperator")]
	public enum EEnvTestScoreOperator : byte
	{
		AverageScore = 0,
		MinScore = 1,
		MaxScore = 2,
		Multiply = 3,
	}
}