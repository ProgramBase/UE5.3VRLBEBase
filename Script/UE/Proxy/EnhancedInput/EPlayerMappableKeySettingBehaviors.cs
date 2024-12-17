using Script.CoreUObject;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EPlayerMappableKeySettingBehaviors")]
	public enum EPlayerMappableKeySettingBehaviors : byte
	{
		InheritSettingsFromAction = 0,
		OverrideSettings = 1,
		IgnoreSettings = 2,
	}
}