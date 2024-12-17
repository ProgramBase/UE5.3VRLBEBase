using Script.CoreUObject;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.EFontLoadingPolicy")]
	public enum EFontLoadingPolicy : byte
	{
		LazyLoad = 0,
		Stream = 1,
		Inline = 2,
	}
}