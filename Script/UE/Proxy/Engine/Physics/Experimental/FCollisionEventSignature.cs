using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FCollisionEventSignature : FMulticastDelegate<Action<TArray<FCollisionChaosEvent>>>
	{
		public FCollisionEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FCollisionEventSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FCollisionChaosEvent> CollisionEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CollisionEvents?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
