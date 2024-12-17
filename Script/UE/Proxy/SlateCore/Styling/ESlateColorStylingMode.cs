using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.ESlateColorStylingMode")]
	public enum ESlateColorStylingMode : byte
	{
		UseColor_Specified = 0,
		UseColor_ColorTable = 1,
		UseColor_Foreground = 2,
		UseColor_Foreground_Subdued = 3,
		UseColor_UseStyle = 4,
	}
}