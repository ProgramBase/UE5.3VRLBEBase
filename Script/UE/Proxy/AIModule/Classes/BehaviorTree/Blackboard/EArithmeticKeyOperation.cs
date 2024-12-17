using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EArithmeticKeyOperation")]
	public enum EArithmeticKeyOperation : byte
	{
		Equal = 0,
		NotEqual = 1,
		Less = 2,
		LessOrEqual = 3,
		Greater = 4,
		GreaterOrEqual = 5,
	}
}