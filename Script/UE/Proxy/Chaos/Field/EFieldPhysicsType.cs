﻿using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldPhysicsType")]
	public enum EFieldPhysicsType : byte
	{
		Field_None = 0,
		Field_DynamicState = 1,
		Field_LinearForce = 2,
		Field_ExternalClusterStrain = 3,
		Field_Kill = 4,
		Field_LinearVelocity = 5,
		Field_AngularVelociy = 6,
		Field_AngularTorque = 7,
		Field_InternalClusterStrain = 8,
		Field_DisableThreshold = 9,
		Field_SleepingThreshold = 10,
		Field_PositionStatic = 11,
		Field_PositionAnimated = 12,
		Field_PositionTarget = 13,
		Field_DynamicConstraint = 14,
		Field_CollisionGroup = 15,
		Field_ActivateDisabled = 16,
		Field_InitialLinearVelocity = 17,
		Field_InitialAngularVelocity = 18,
		Field_LinearImpulse = 19,
	}
}