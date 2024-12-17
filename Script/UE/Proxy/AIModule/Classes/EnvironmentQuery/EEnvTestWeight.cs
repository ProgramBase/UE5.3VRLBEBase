using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EEnvTestWeight")]
	public enum EEnvTestWeight : long
	{
		None = 0,
		Square = 1,
		Inverse = 2,
		Unused = 3,
		Constant = 4,
		Skip = 5,
	}
}