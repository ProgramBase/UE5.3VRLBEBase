using Script.CoreUObject;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.EProjectPackagingBuildConfigurations")]
	public enum EProjectPackagingBuildConfigurations : byte
	{
		PPBC_Debug = 0,
		PPBC_DebugGame = 1,
		PPBC_Development = 2,
		PPBC_Test = 3,
		PPBC_Shipping = 4,
	}
}