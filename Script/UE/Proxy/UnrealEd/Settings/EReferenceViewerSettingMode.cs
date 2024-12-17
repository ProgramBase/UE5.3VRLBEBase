using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EReferenceViewerSettingMode")]
	public enum EReferenceViewerSettingMode : byte
	{
		NoPreference = 0,
		ShowByDefault = 1,
		HideByDefault = 2,
	}
}