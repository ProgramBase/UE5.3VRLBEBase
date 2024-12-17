using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	public class FOnChaosCollisionEvents : FMulticastDelegate<Action<TArray<FChaosCollisionEventData>>>
	{
		public FOnChaosCollisionEvents() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnChaosCollisionEvents() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FChaosCollisionEventData> CollisionEvents)
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
