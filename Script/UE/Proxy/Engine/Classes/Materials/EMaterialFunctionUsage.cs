using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMaterialFunctionUsage")]
	public enum EMaterialFunctionUsage : byte
	{
		Default = 0,
		MaterialLayer = 1,
		MaterialLayerBlend = 2,
	}
}