using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EWidgetInteractionSource")]
	public enum EWidgetInteractionSource : byte
	{
		World = 0,
		Mouse = 1,
		CenterScreen = 2,
		Custom = 3,
	}
}