using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPlayOnLaunchConfiguration")]
	public enum EPlayOnLaunchConfiguration : byte
	{
		LaunchConfig_Default = 0,
		LaunchConfig_Debug = 1,
		LaunchConfig_Development = 2,
		LaunchConfig_Test = 3,
		LaunchConfig_Shipping = 4,
	}
}