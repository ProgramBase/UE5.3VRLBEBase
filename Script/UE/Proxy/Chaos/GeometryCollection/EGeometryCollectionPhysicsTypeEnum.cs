﻿using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EGeometryCollectionPhysicsTypeEnum")]
	public enum EGeometryCollectionPhysicsTypeEnum : byte
	{
		Chaos_AngularVelocity = 0,
		Chaos_DynamicState = 1,
		Chaos_LinearVelocity = 2,
		Chaos_InitialAngularVelocity = 3,
		Chaos_InitialLinearVelocity = 4,
		Chaos_CollisionGroup = 5,
		Chaos_LinearForce = 6,
		Chaos_AngularTorque = 7,
		Chaos_DisableThreshold = 8,
		Chaos_SleepingThreshold = 9,
		Chaos_ExternalClusterStrain = 10,
		Chaos_InternalClusterStrain = 11,
		Chaos_LinearImpulse = 12,
		Chaos_Max = 13,
	}
}