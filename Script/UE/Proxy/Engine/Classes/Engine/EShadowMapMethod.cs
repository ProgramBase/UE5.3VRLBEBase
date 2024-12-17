using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EShadowMapMethod")]
	public enum EShadowMapMethod : byte
	{
		ShadowMaps = 0,
		VirtualShadowMaps = 1,
	}
}