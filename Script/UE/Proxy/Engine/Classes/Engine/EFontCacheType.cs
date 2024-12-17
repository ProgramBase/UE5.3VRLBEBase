using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EFontCacheType")]
	public enum EFontCacheType : byte
	{
		Offline = 0,
		Runtime = 1,
	}
}