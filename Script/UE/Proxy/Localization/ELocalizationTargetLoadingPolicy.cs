using Script.CoreUObject;

namespace Script.Localization
{
	[PathName("/Script/Localization.ELocalizationTargetLoadingPolicy")]
	public enum ELocalizationTargetLoadingPolicy : long
	{
		Never = 0,
		Always = 1,
		Editor = 2,
		Game = 3,
		PropertyNames = 4,
		ToolTips = 5,
	}
}