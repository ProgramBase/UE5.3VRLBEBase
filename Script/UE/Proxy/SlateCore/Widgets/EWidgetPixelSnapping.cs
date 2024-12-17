using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EWidgetPixelSnapping")]
	public enum EWidgetPixelSnapping : byte
	{
		Inherit = 0,
		Disabled = 1,
		SnapToPixel = 2,
	}
}