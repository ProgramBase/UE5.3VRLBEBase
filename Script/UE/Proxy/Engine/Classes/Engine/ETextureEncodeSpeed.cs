using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureEncodeSpeed")]
	public enum ETextureEncodeSpeed : byte
	{
		Final = 0,
		FinalIfAvailable = 1,
		Fast = 2,
	}
}