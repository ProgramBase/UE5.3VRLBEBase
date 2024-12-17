using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERuntimeVirtualTextureMipValueMode")]
	public enum ERuntimeVirtualTextureMipValueMode : byte
	{
		RVTMVM_None = 0,
		RVTMVM_MipLevel = 1,
		RVTMVM_MipBias = 2,
		RVTMVM_RecalculateDerivatives = 3,
	}
}