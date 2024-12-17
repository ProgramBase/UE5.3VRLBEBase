using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EFontHinting")]
	public enum EFontHinting : byte
	{
		Default = 0,
		Auto = 1,
		AutoLight = 2,
		Monochrome = 3,
		None = 4,
	}
}