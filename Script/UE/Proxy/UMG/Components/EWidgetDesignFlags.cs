using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EWidgetDesignFlags")]
	public enum EWidgetDesignFlags : long
	{
		None = 0,
		Designing = 1,
		ShowOutline = 2,
		ExecutePreConstruct = 4,
		Previewing = 8,
	}
}