using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EWidgetClipping")]
	public enum EWidgetClipping : byte
	{
		Inherit = 0,
		ClipToBounds = 1,
		ClipToBoundsWithoutIntersecting = 2,
		ClipToBoundsAlways = 3,
		OnDemand = 4,
	}
}