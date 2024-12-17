using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ESimulationSpace")]
	public enum ESimulationSpace : byte
	{
		ComponentSpace = 0,
		WorldSpace = 1,
		BaseBoneSpace = 2,
	}
}