using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTestScoreEquation")]
	public enum EEnvTestScoreEquation : byte
	{
		Linear = 0,
		Square = 1,
		InverseLinear = 2,
		SquareRoot = 3,
		Constant = 4,
	}
}