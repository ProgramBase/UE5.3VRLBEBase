using Script.CoreUObject;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.EPhysicsType")]
	public enum EPhysicsType : byte
	{
		PhysType_Default = 0,
		PhysType_Kinematic = 1,
		PhysType_Simulated = 2,
	}
}