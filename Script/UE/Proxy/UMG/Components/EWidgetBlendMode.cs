using Script.CoreUObject;

namespace Script.UMG
{
	[PathName("/Script/UMG.EWidgetBlendMode")]
	public enum EWidgetBlendMode : byte
	{
		Opaque = 0,
		Masked = 1,
		Transparent = 2,
	}
}