using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureColorChannel")]
	public enum ETextureColorChannel : byte
	{
		TCC_Red = 0,
		TCC_Green = 1,
		TCC_Blue = 2,
		TCC_Alpha = 3,
	}
}