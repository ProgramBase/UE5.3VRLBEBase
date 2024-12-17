using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.TextureAddress")]
	public enum TextureAddress : byte
	{
		TA_Wrap = 0,
		TA_Clamp = 1,
		TA_Mirror = 2,
	}
}