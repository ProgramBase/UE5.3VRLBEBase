using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EBlueprintBreakpointReloadMethod")]
	public enum EBlueprintBreakpointReloadMethod : int
	{
		RestoreAll = 0,
		RestoreAllAndDisable = 1,
		DiscardAll = 2,
	}
}