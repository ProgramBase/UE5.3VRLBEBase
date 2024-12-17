using Script.CoreUObject;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.EProjectPackagingBlueprintNativizationMethod")]
	public enum EProjectPackagingBlueprintNativizationMethod : byte
	{
		Disabled = 0,
		Inclusive = 1,
		Exclusive = 2,
	}
}