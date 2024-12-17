using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldVectorType")]
	public enum EFieldVectorType : byte
	{
		Vector_LinearForce = 0,
		Vector_LinearVelocity = 1,
		Vector_AngularVelocity = 2,
		Vector_AngularTorque = 3,
		Vector_PositionTarget = 4,
		Vector_InitialLinearVelocity = 5,
		Vector_InitialAngularVelocity = 6,
		Vector_LinearImpulse = 7,
		Vector_TargetMax = 8,
	}
}