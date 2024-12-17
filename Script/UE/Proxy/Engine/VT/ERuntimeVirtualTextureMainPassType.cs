using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERuntimeVirtualTextureMainPassType")]
	public enum ERuntimeVirtualTextureMainPassType : byte
	{
		Never = 0,
		Exclusive = 1,
		Always = 2,
	}
}