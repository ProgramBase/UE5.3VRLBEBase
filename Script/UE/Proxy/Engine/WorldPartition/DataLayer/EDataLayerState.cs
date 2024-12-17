using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDataLayerState")]
	public enum EDataLayerState : byte
	{
		Unloaded = 0,
		Loaded = 1,
		Activated = 2,
	}
}