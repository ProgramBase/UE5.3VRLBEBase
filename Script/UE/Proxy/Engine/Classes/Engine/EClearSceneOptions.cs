using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EClearSceneOptions")]
	public enum EClearSceneOptions : byte
	{
		NoClear = 0,
		HardwareClear = 1,
		QuadAtMaxZ = 2,
	}
}