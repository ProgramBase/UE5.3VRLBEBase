using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECustomDepthStencil")]
	public enum ECustomDepthStencil : byte
	{
		Disabled = 0,
		Enabled = 1,
		EnabledOnDemand = 2,
		EnabledWithStencil = 3,
	}
}