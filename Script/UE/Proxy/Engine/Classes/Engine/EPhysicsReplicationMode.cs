using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPhysicsReplicationMode")]
	public enum EPhysicsReplicationMode : byte
	{
		Default = 0,
		PredictiveInterpolation = 1,
		Resimulation = 2,
	}
}