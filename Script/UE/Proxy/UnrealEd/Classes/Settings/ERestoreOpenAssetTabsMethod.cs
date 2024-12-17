using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ERestoreOpenAssetTabsMethod")]
	public enum ERestoreOpenAssetTabsMethod : byte
	{
		AlwaysPrompt = 0,
		AlwaysRestore = 1,
		NeverRestore = 2,
	}
}