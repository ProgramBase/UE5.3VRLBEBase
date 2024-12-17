using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	public class FOnChaosPhysicsCollision : FMulticastDelegate<Action<FChaosPhysicsCollisionInfo>>
	{
		public FOnChaosPhysicsCollision() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChaosPhysicsCollision() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FChaosPhysicsCollisionInfo CollisionInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CollisionInfo?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
