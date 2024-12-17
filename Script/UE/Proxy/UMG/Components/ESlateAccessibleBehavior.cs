using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.ESlateAccessibleBehavior")]
	public enum ESlateAccessibleBehavior : byte
	{
		NotAccessible = 0,
		Auto = 1,
		Summary = 2,
		Custom = 3,
		ToolTip = 4,
	}
}