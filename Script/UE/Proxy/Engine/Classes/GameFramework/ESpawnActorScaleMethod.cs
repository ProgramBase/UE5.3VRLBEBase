using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESpawnActorScaleMethod")]
	public enum ESpawnActorScaleMethod : byte
	{
		OverrideRootScale = 0,
		MultiplyWithRoot = 1,
		SelectDefaultAtRuntime = 2,
	}
}