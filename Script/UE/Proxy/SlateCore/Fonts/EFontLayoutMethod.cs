using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EFontLayoutMethod")]
	public enum EFontLayoutMethod : byte
	{
		Metrics = 0,
		BoundingBox = 1,
	}
}