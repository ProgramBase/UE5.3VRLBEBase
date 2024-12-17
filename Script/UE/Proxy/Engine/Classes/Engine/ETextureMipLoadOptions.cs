using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureMipLoadOptions")]
	public enum ETextureMipLoadOptions : byte
	{
		Default = 0,
		AllMips = 1,
		OnlyFirstMip = 2,
	}
}