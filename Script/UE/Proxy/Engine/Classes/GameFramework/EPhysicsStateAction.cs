using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPhysicsStateAction")]
	public enum EPhysicsStateAction : byte
	{
		AddForce = 0,
		AddTorque = 1,
		AddForceAtPosition = 2,
		AddLinearVelocity = 3,
		AddAngularVelocity = 4,
		AddVelocityAtPosition = 5,
		AddLinearImpulse = 6,
		AddAngularImpulse = 7,
		AddImpulseAtPosition = 8,
		AddAcceleration = 9,
		NumActions = 10,
	}
}