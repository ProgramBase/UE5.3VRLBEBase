using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPhysicsTransformUpdateMode")]
	public enum EPhysicsTransformUpdateMode : byte
	{
		SimulationUpatesComponentTransform = 0,
		ComponentTransformIsKinematic = 1,
	}
}