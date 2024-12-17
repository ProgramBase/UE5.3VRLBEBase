using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureMipValueMode")]
	public enum ETextureMipValueMode : byte
	{
		TMVM_None = 0,
		TMVM_MipLevel = 1,
		TMVM_MipBias = 2,
		TMVM_Derivative = 3,
	}
}