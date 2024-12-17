using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDataLayerRuntimeState")]
	public enum EDataLayerRuntimeState : byte
	{
		Unloaded = 0,
		Loaded = 1,
		Activated = 2,
	}
}