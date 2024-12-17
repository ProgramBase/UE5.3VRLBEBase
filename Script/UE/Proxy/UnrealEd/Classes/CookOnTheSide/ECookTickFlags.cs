using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ECookTickFlags")]
	public enum ECookTickFlags : long
	{
		None = 0,
		MarkupInUsePackages = 1,
		HideProgressDisplay = 2,
	}
}