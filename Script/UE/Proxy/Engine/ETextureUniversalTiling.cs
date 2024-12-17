using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureUniversalTiling")]
	public enum ETextureUniversalTiling : byte
	{
		Disabled = 0,
		Enabled_256KB = 1,
		Enabled_64KB = 2,
	}
}